using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data;
using TestingWebPortal.Data.Interfaces;
using TestingWebPortal.Data.Models;
using TestingWebPortal.DTO;

namespace TestingWebPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionReposetory _questionReposetory;
        public QuestionController(IQuestionReposetory questionReposetory)
        {
            _questionReposetory = questionReposetory;
        }
        [HttpPost("Add-Question")]
        public IActionResult AddQuestion(QuestionDTO dto)
        {
           
            var question = new Question
            {
                _Question = dto._Question,
                Answers = dto.Answers,
            };
            return Created("Question successful created.", _questionReposetory.Create(question));
        }
        [HttpGet("getAllQuestions")]
        public IActionResult GetAllQuestions()
        {
            return Ok(_questionReposetory.GetAllQuestions());

        }
    }
}
