using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Models;

namespace TestingWebPortal.Data.Interfaces
{
    public interface IResultReposetory
    {
        Result Create(Result result);
        
    }
}
