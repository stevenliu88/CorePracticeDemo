using CorePractice.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CorePractice.Application.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);

        Task InsertUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserByIdAsync(int id);

    }
}
