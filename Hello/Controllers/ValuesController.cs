using System.Collections.Generic;
using Hello.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hello.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private FixedModel model;

        public ValuesController(FixedModel _model) {
            model = _model;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return model.values;
        }
    }
}
