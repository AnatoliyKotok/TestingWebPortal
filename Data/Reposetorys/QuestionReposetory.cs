using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Interfaces;
using TestingWebPortal.Data.Models;

namespace TestingWebPortal.Data.Reposetorys
{
    public class QuestionReposetory : IQuestionReposetory
    {
        private readonly AppDbContext _context;
        public QuestionReposetory(AppDbContext context) {
            _context = context;

        }
        
        public Question Create(Question question)
        {
           
            _context.Questions.Add(question);
            _context.SaveChanges();
            var _question = _context.Questions.FirstOrDefault(q => q._Question == question._Question);
            return _question;
        }

        public List<Question> GetAllQuestions()
        {
            return _context.Questions.ToList();
        }
    }
}
