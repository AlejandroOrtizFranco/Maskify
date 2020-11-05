using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maskify.Models;
using Maskify.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Maskify.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaskController : ControllerBase
    {
        private readonly IMaskifyService _service;

        public MaskController(IMaskifyService service)
        {
            _service = service;
        }
        // GET: api/<MaskController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MaskController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MaskController>
        [HttpPost]
        public ActionResult<string> Post(MaskDto stringToMaskify)
        {
            return Ok(new {Result = _service.PostMaskify(stringToMaskify.StringToMaskify)});
        }

        // PUT api/<MaskController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MaskController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
