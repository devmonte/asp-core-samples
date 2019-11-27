using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClient.Services
{
    public class GitHubService
    {
        public System.Net.Http.HttpClient GitHubClient { get; set; }

        public GitHubService(System.Net.Http.HttpClient client)
        {
            client.BaseAddress = new Uri("https://api.github.com/");
            client.DefaultRequestHeaders.Add("Accept",
                "application/vnd.github.v3+json");
            client.DefaultRequestHeaders.Add("User-Agent",
                "HttpClientFactory-Sample");

            GitHubClient = client;
        }

        public async Task<string> GetAspCoreSamplesBranches()
        {
            var response = await GitHubClient.GetAsync(
                "repos/devmonte/net-core-samples/branches");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
