using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Interfaces;
using TestingWebPortal.Data.Models;

namespace TestingWebPortal.Data.Reposetorys
{
    public class RsultReposetory:IResultReposetory
    {
        private readonly AppDbContext _context;
        public RsultReposetory(AppDbContext context)
        {
            _context = context;
        }

        public Result Create(Result result)
        {
            _context.Results.Add(result);
            _context.SaveChanges();
            var _result = _context.Results.FirstOrDefault(r => r.UserId == result.UserId);
            return _result;
        }

      
       
    }
}
