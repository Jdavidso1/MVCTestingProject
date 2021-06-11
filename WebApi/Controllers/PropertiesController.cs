using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Models;
using WebApi.Repository;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertiesController: ControllerBase {
        private PropertyRepo _propertyrepo;
        public PropertiesController() {
            _propertyrepo = new PropertyRepo();
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<List<Property>> Get(int id) {
            // var PropertyList = new List<Property>();
            // PropertyList.Add(new Property() {
            //     Name = "new property",
            //     Address = "new addy",
            //     Id = 1,
            // });
            return Ok(_propertyrepo.Get(id));
        }

        [HttpPost]
        public ActionResult Post(Property property) {
            _propertyrepo.Create(property);
            return Ok();
        }
    }
}