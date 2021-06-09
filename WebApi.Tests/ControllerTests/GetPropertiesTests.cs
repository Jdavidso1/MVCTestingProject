using NUnit.Framework;
using Moq;
using WebApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Tests
{
    public class Tests
    {
        private PropertiesController _propertiesController;
        [SetUp]
        public void Setup()
        {
            _propertiesController = new PropertiesController();
        }

        [Test]
        public void GetProperties_ReturnsNone()
        {
            var properties = _propertiesController.Get(1);
            Assert.IsInstanceOf(typeof(NoContentResult), properties);
        }

        [Test]
        public void GetProperties_ReturnsOne()
        {
            var properties = _propertiesController.Get(2);
            Assert.IsInstanceOf(typeof(OkObjectResult), properties.Result);
            Assert.AreEqual(properties.Value.Count, 1);
        }
    }
}