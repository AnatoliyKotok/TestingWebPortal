using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Models;

namespace TestingWebPortal.DTO
{
    public class QuestionDTO
    {
        public string _Question { get; set; }
        public HashSet<Answer> Answers { get; set; }
        public int Mark { get; set; }
    }
}
