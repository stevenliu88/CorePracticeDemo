using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorePractice.Application.Models;
using CorePractice.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorePractice.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<User> GetUser(int userId)
        {
            return await _userService.GetUserByIdAsync(userId);
        }
        [HttpPost]
        public async Task AddUser(User user)
        {
            await _userService.InsertUserAsync(user);
        }

        [HttpDelete]
        public async Task DeleteUser(int id)
        {
            await _userService.DeleteUserByIdAsync(id);
        }
    }
}