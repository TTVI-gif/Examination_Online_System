using ExaminationOnlineSystem.Service;
using ExaminationOnlineSystem.ViewModel.UserViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Controllers
{
    [Route("[controller][action]")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Authenticate(UserLoginRequest userLogin)
        {
            var resultToken = _userService.Authenticate(userLogin);
            if (resultToken == null)
                return BadRequest();
            return Ok(resultToken);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync([FromForm] UserRegisterRequest userRegisterRequest)
        {
            var user = await _userService.RegisterAsync(userRegisterRequest);
            if (user == null)
                return BadRequest("Đăng kí không thành công.");
            return Ok(user);
        }

    }
}
