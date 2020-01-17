using CorePractice.Application.Models;
using CorePractice.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CorePractice.Application.Services
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int id);
        Task InsertUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserByIdAsync(int id);
    }
    class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByIdAsync(int id) 
        {
            return await _userRepository.GetUserByIdAsync(id);
        }
        public async Task InsertUserAsync(User user) 
        {
            await _userRepository.InsertUserAsync(user);
        }
        public async Task UpdateUserAsync(User user) 
        {
            await _userRepository.UpdateUserAsync(user);
        }
        public async Task DeleteUserByIdAsync(int userId) 
        {
            await _userRepository.DeleteUserByIdAsync(userId);
        }
    }
}
