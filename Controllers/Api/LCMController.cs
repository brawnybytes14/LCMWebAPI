using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCMWebAPI.Data;
using LCMWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LCMWebAPI.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LCMController : ControllerBase
    {

        private ApplicationDbContext _context;

        public LCMController(ApplicationDbContext context)
        {
            _context = context;
        }

        //protected override void Dispose(bool disposing)
        //{
        //    _context.Dispose();
        //}
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }
}