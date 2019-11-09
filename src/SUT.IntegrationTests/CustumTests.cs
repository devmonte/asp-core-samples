using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace SUT.IntegrationTests
{
    public class CustumTests: IClassFixture<CustomFactory<Startup>>
    {
        private readonly CustomFactory<Startup> _webApplicationFactory;

        public CustumTests(CustomFactory<Startup> webApplicationFactory)
        {
            _webApplicationFactory = webApplicationFactory;
        }

        [Fact]
        public async Task Index2_WhenCalled_ShouldReturnValue()
        {
            //Arrange
            var client = _webApplicationFactory.CreateClient();

            //Act
            var response = await client.GetAsync($"{client.BaseAddress}Home/GetValue");

            //Assert
            Assert.Equal(true, response.IsSuccessStatusCode);
        }
    }
}
