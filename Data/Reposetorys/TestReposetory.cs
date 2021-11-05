using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Interfaces;
using TestingWebPortal.Data.Models;

namespace TestingWebPortal.Data.Reposetorys
{
    public class TestReposetory : ITestReposetory
    {
        private readonly AppDbContext _context;
        public TestReposetory(AppDbContext context)
        {
            _context = context;

        }
        public Test AddTest(Test test)
        {
            _context.Tests.Add(test);
            _context.SaveChanges();
            var _test = _context.Tests.FirstOrDefault(q => q.Topic == test.Topic);
            return _test;
        }

        public List<Test> GetAllTest()
        {
            _context.Answers.ToList();
            _context.Questions.ToList();
            var test=_context.Tests.Distinct().ToList();
            return test;
        }
        
    }
}
