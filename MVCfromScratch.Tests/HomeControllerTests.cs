using System;
using MVCfromScratch.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;


namespace MVCfromScratch.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_Hello_World()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.Equal("Hello World!", result);
        }
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new HomeController();

            var result = underTest.Index1();

            Assert.IsType<ViewResult>(result);
        }

    }
}
