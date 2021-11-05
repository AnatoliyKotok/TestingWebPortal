using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestingWebPortal.Data.Models;

namespace TestingWebPortal.Data.Repositories
{
    public class UserReposetory : IUserReposetory
    {
        private readonly AppDbContext _context;

        public UserReposetory(AppDbContext context)
        {
            _context = context;
        }
        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            var _user = _context.Users.FirstOrDefault(u => u.Login == user.Login);

            return _user;
        }

        public User GetUserByLogin(string login)
        {
            return _context.Users.FirstOrDefault(u => u.Login == login);
        }
        public User GetUserById(int Id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == Id);
        }
    }
}
