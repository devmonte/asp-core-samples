using System;
using System.Threading.Tasks;
using Binding.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NSubstitute;
using SUT.Controllers;
using SUT.Services;
using Xunit;

namespace SUT.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public async Task Index2_WhenCalled_ShouldReturnValue()
        {
            //Arrange
            var loggerMock = Substitute.For<ILogger<HomeController>>();
            var serviceMock = Substitute.For<IExampleService>();
            var ctrl = new HomeController(loggerMock, serviceMock);

            //Act
            var result = await ctrl.Index();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Index2_WhenCalledWithWrongData_ShouldReturnBadRequestResult()
        {
            //Arrange
            var loggerMock = Substitute.For<ILogger<HomeController>>();
            var serviceMock = Substitute.For<IExampleService>();
            var ctrl = new HomeController(loggerMock, serviceMock);
            ctrl.ModelState.AddModelError("Data", "Required!");

            //Act
            var result = await ctrl.Add(new ExampleModel());

            //Assert
            var viewResult = Assert.IsType<BadRequestResult>(result);
        }

    }
}
