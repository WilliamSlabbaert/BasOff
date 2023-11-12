using _02BasOffBL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BasOffDL.Repo
{
    public class LoginRepo : ILoginRepo
    {
        public string Login()
        {
            return "hello from repo";
        }
    }
}
