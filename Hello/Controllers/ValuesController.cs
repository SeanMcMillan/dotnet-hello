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

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
