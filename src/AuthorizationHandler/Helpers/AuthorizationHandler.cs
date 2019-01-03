using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HttpClientFactory.Helpers
{
    public class AuthorizationHandler : DelegatingHandler
    {
        private string _token;
        private object _apiConsumer;
        private Uri _authUri;
        public AuthorizationHandler(object apiConsumer, Uri authUri)
        {
            _apiConsumer = apiConsumer;
            _authUri = authUri;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if(!string.IsNullOrEmpty(_token))
                request.Headers.Add("Authorization", $"Bearer {_token}");

            var response = base.SendAsync(request, cancellationToken);
            if (response.Result.StatusCode == HttpStatusCode.Unauthorized)
            {
                _token = GetToken();
                request.Headers.Add("Authorization", $"Bearer {_token}");
                var lastResponse = base.SendAsync(request, cancellationToken);
                return lastResponse;
            }

            return response;
        }

        private string GetToken()
        {
            var authorizeRequest = new HttpRequestMessage(HttpMethod.Post, _authUri);
            authorizeRequest.Headers.Add("Api-Version", "1.0");

            authorizeRequest.Content = new StringContent(JsonConvert.SerializeObject(_apiConsumer), Encoding.UTF8, "application/json");

            var authCancellationToken = new CancellationToken();
            var authResponse = base.SendAsync(authorizeRequest, authCancellationToken);
            dynamic responseBodyJson = JsonConvert.DeserializeObject(authResponse.Result.Content.ReadAsStringAsync().Result);
            return responseBodyJson.token;
        }
    }
}