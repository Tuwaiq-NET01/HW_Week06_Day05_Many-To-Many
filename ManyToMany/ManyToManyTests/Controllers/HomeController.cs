using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ManyToMany;
using ManyToMany.Controllers;
using ManyToMany.Data;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ManyToManyTests.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        private static WebApplicationFactory<Startup> _factory;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            // Web app simulator
            _factory = new WebApplicationFactory<Startup>();
        }

        [TestMethod]
        public async Task ShouldReturnSuccessResponse()
        {
            var client = _factory.CreateClient();
            //StringContent queryString = new StringContent("test=something");
            //client.PostAsync("/Home", queryString);
            var response = await client.GetAsync("/Home");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("application/json; charset=utf-8", response.Content.Headers.ContentType?.ToString());

            var json = await response.Content.ReadAsStringAsync();
            var expectedJSON = "[{\"id\":1,\"studentId\":1,\"teacherId\":1}]";
            Assert.AreEqual(expectedJSON, json);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _factory.Dispose();
        }
    }
}
