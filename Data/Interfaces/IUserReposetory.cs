using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Models;

namespace TestingWebPortal.Data
{
    public interface IUserReposetory
    {
        User Create(User user);
        User GetUserByLogin(string login);
        User GetUserById(int Id);
    }
}
