using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Models;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController: ControllerBase {
        public PropertiesController() {
        }
        [HttpGet]
        public ActionResult<List<Property>> Get(int id) {
            var PropertyList = new List<Property>();
            PropertyList.Add(new Property() {
                Name = "new property",
                Address = "new addy",
                Id = 1,
            });
            return Ok(PropertyList);
        }
    }
}