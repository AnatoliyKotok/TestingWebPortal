using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingWebPortal.Data.Interfaces
{
    public interface IQuestionReposetory
    {
        Question Create(Question question);
        List<Question> GetAllQuestions();
    }
}
