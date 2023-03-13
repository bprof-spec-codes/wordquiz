﻿using WordQuiz.Data;
using WordQuiz.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.SignalR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WordQuiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordStaticController : ControllerBase
    {
        // GET: api/<WordStaticController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WordStaticController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WordStaticController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WordStaticController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WordStaticController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
