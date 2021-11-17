﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace getone.Controllers
{
    [ApiController]
    [Route("/Students")]
    public class StudentsController : ControllerBase
    {

        [HttpPost("Filingapplication")]
        public string Filingapplication(string str)
        {
            return str; // Подача заявок на поступление
        }
        [HttpPost("Serviceevaluation")]
        public string Serviceevaluation(string str)
        {
            return str;// Оценка работы сервиса
        }
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