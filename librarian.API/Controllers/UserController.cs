using librarian.API.Dtos.User;
using librarian.API.Dtos.UserBook;
using librarian.API.Models;
using librarian.API.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarian.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;
        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserDto newUser)
        {
            ServiceResponse<UserDto> response = await _userService.AddUser(newUser);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserDto updateUser)
        {
            ServiceResponse<GetUserDto> response = await _userService.UpdateUser(updateUser);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPut("updateUserBookList")]
        public async Task<IActionResult> UpdateUserBookList(List<PlainUserBookDto> ubList)
        {
            ServiceResponse<List<PlainUserBookDto>> response = await _userService.UpdateUserBookList(ubList);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            ServiceResponse<GetUserDto> response = await _userService.Login(login);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost("pwd")]
        public async Task<IActionResult> PasswordChange(PasswordChangeDto pwdChange)
        {
            ServiceResponse<UserDto> response = await _userService.PasswordChange(pwdChange);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
