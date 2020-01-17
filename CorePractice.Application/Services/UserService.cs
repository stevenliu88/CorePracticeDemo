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
        Task<User> InsertUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task<int> DeleteUserByIdAsync(int id);
    }
    public class UserService : IUserService
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
        public async Task<User> InsertUserAsync(User user) 
        {
            await _userRepository.InsertUserAsync(user);
            return user;
        }
        public async Task UpdateUserAsync(User user) 
        {
            //await _userRepository.UpdateUserAsync(user);
            throw new NotImplementedException();
        }
        public async Task<int> DeleteUserByIdAsync(int userId) 
        {
            await _userRepository.DeleteUserByIdAsync(userId);
            return userId;
        }
    }
}
