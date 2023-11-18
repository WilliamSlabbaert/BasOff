using _02BasOffBL.DTO;
using _02BasOffBL.Reponse;
using _02BasOffBL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private ILogger<LoginController> _logger;
        private ILoginService _loginService;
        public LoginController(ILogger<LoginController> logger, ILoginService loginService)
        {
            _logger = logger;
            _loginService = loginService;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("test");
        }
        [HttpPost]
        public ActionResult<BaseResponse> Login([FromBody] UserCredentialsDTO? credentials = null)
        {
            return Ok(_loginService.Login(credentials));
        }
    }
}
