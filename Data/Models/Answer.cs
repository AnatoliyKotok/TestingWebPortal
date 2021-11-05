using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.DTO;

namespace TestingWebPortal.Data.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string _Answer { get; set; }
        public bool isCorect { get; set; }
        
    }
}
