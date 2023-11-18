using _01BasOffEL.Entities;
using _02BasOffBL.DTO;
using _02BasOffBL.Mapping;
using _02BasOffBL.Repo;
using _02BasOffBL.Reponse;
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

        public BaseResponse Login(UserCredentialsDTO userCredentials)
        {
            try
            {
                var credentialsMapping = CredentialMapping.BaseCredentialMapping(userCredentials);
                var responseItem = _loginRepo.Login(credentialsMapping);

                return new BaseResponse().SuccessResponse("LOGIN SUCCESSFULL", responseItem);
            }
            catch (Exception ex)
            {
                return new BaseResponse().FailedResponse("LOGIN FAILED");
            }
            
        }
    }
}
