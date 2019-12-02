using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HttpClient.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HttpClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HttpController : ControllerBase
    {
        private readonly ILogger<HttpController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly GitHubService _gitHubService;

        public HttpController(ILogger<HttpController> logger, IHttpClientFactory httpClientFactory, GitHubService gitHubService)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _gitHubService = gitHubService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var httpClient = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/repos/devmonte/net-core-samples/branches");
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            var response = await httpClient.SendAsync(request);
            return Ok(await response.Content.ReadAsStringAsync());
        }
        
        [HttpGet("named")]
        public async Task<IActionResult> GetNamed()
        {
            var httpClient = _httpClientFactory.CreateClient("github");
            var request = new HttpRequestMessage(HttpMethod.Get, "repos/devmonte/net-core-samples/branches");
            var response = await httpClient.SendAsync(request);
            return Ok(await response.Content.ReadAsStringAsync());
        }

        [HttpGet("typed")]
        public async Task<IActionResult> GetTyped()
        {
            return Ok(await _gitHubService.GetAspCoreSamplesBranches());
        }
    }
}
