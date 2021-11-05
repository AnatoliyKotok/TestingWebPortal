using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Models;
using TestingWebPortal.DTO;

namespace TestingWebPortal.Data
{
    public class Question
    {

        
        public int Id { get; set; }
        public string _Question { get; set; }
        public HashSet<Answer> Answers { get; set; }
        public int Mark { get; set; }


        
    }
}
