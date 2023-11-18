using _02BasOffBL.DTO;
using _02BasOffBL.Reponse;

namespace _02BasOffBL.Services.Interfaces
{
    public interface ILoginService
    {
        public BaseResponse Login(UserCredentialsDTO userCredentials);
    }
}
