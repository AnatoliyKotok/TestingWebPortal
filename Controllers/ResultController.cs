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
    public class ResultController : ControllerBase
    {
        private readonly IResultReposetory resultReposetory;
        public ResultController(IResultReposetory _resultReposetory )
        {
            resultReposetory = _resultReposetory;
        }
        [HttpPost("AddResult")]
        public IActionResult Crate(ResultDTO _result)
        {
            var result = new Result
            {
                
                TestId=_result.TestId,
                
                UserId=_result.UserId
            };
            return Created("Question successful created.", resultReposetory.Create(result));
        }
    }
}
