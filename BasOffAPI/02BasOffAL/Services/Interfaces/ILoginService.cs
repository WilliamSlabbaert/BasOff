using _02BasOffBL.DTO;

namespace _02BasOffBL.Services.Interfaces
{
    public interface ILoginService
    {
        public string Login(UserCredentialsDTO userCredentials);
    }
}
