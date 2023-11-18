using _01BasOffDL.Context;
using _01BasOffEL.Entities;
using _02BasOffBL.Repo;
using Microsoft.EntityFrameworkCore;

namespace _01BasOffDL.Repo
{
    public class LoginRepo : ILoginRepo
    {
        private MyDBContext _context;
        private DbSet<UserCredentialsEntity> _dbSet;
        public LoginRepo(MyDBContext context)
        {
            _context = context;
        }
        public string Login(UserCredentialsEntity credentials)
        {
            var response = _context.Users.FirstOrDefault(s => s.Username == credentials.Username && s.Password == credentials.Password);
            return response == null ? "not found" : response.Username + " => " + response.Password;
        }

    }
}
