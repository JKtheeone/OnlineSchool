using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Schedule.Controllers
{
    [ApiController]
    [Route("/Schedule")]
    public class Schedule : ControllerBase
    {
        [HttpPost]
        public string Create(string str)
        {
            return str;
        }
        [HttpGet]
        public string Read(string str)
        {
            return str;
        }
        [HttpPut]
        public string Update(string str)
        {
            return str;
        }
        [HttpDelete]
        public string Delete(string str)
        {
            return str;
        }
    }
}