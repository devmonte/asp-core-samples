using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using static Xunit.Assert;

namespace SUT.IntegrationTests
{
    public class HomeControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _webApplicationFactory;

        public HomeControllerTests(WebApplicationFactory<Startup> webApplicationFactory)
        {
            _webApplicationFactory = webApplicationFactory;
        }

        [Fact]
        public async Task Index2_WhenCalled_ShouldReturnValue()
        {
            //Arrange
            var client = _webApplicationFactory.CreateClient();

            //Act
            var response = await client.GetAsync($"{client.BaseAddress}Home/Index");

            //Assert
            Equal(true, response.IsSuccessStatusCode);
        }
    }
}
