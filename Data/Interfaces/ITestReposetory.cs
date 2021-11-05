using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Models;

namespace TestingWebPortal.Data.Interfaces
{
    public interface ITestReposetory
    {
        Test AddTest(Test test);
        void DeleteTest(int Id);
        List<Test> GetAllTest();
    }
}
