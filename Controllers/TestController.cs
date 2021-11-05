using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Interfaces;
using TestingWebPortal.Data.Models;
using TestingWebPortal.DTO;

namespace TestingWebPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestReposetory _testReposetory;
        public TestController(ITestReposetory testReposetory)
        {
            _testReposetory = testReposetory;
        }
        [HttpPost("Add-Test")]
        public IActionResult AddTest(TestDTO dto)
        {
            var test = new Test
            {
                Topic = dto.Topic,
                Date = dto.Date,
                Questions = dto.Questions,
            };
            return Created("Question successful created.", _testReposetory.AddTest(test));
        }
        [HttpDelete("delete-test")]
        public IActionResult DeleteTestById(int id)
        {
            _testReposetory.DeleteTest(id);
            return Ok();
        }
        [HttpGet("Get-All-Tests")]
        public IActionResult GetAllTests()
        {
            return Ok(_testReposetory.GetAllTest());
        }

    }
}
