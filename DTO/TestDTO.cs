using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data;

namespace TestingWebPortal.DTO
{
    public class TestDTO
    {
        public string Topic { get; set; }
        public DateTime Date { get; set; }
        public HashSet<Question> Questions { get; set; }
    }
}
