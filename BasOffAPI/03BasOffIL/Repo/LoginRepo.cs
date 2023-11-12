using _02BasOffBL.Repo;


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
