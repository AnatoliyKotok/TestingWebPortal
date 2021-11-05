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
        List<Test> GetAllTest();
    }
}
