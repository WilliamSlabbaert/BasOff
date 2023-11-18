using _01BasOffEL.Entities;
using _02BasOffBL.DTO;
using _02BasOffBL.Mapping;
using _02BasOffBL.Repo;
using _02BasOffBL.Services.Interfaces;

namespace _02BasOffBL.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepo _loginRepo;
        public LoginService(ILoginRepo loginRepo) 
        {
            _loginRepo = loginRepo;
        }

        public string Login(UserCredentialsDTO userCredentials)
        {
            var credentialsMapping = CredentialMapping.BaseCredentialMapping(userCredentials);
            return _loginRepo.Login(credentialsMapping);
        }
    }
}
