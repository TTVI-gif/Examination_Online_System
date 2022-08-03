using ExaminationOnlineSystem.Filter;
using ExaminationOnlineSystem.Service;
using ExaminationOnlineSystem.ViewModel.UserViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExaminationOnlineSystem.Controllers
{
    [AuthorizeFilter(role: "Admin")]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            return Ok(user);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromForm] UserUpdateRequest user)
        {
            if (user == null)
                return BadRequest();
            var result = await _userService.UpdateAsync(user);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _userService.DeleteAsync(id);
            if (!result)
                return BadRequest();
            return Ok(result);
        }
    }
}
