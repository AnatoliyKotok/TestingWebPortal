using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingWebPortal.Data.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Topic  { get; set; }
        public DateTime Date { get; set; }
        public HashSet<Question> Questions { get; set; }
    }
}
