using CorePractice.Application.Models;
using CorePractice.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorePractice.Infrastructure.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly CoreContext _coreContext;
        public UserRepository(CoreContext coreContext) 
        {
            _coreContext = coreContext;
        }

        public async Task<User> GetUserByIdAsync(int id) 
        {
            return await _coreContext.Users.Where(x=>x.UserId == id).FirstOrDefaultAsync();
        }

        public async Task InsertUserAsync(User user) 
        {
            _coreContext.Users.Add(user);
            await _coreContext.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user) 
        {
            _coreContext.Users.Update(user);
            await _coreContext.SaveChangesAsync();
        }

        public async Task DeleteUserByIdAsync(int id)
        {
            User user = await _coreContext.Users.Where(x => x.UserId == id).FirstOrDefaultAsync();
            _coreContext.Users.Remove(user);
            await _coreContext.SaveChangesAsync();
        }

    }
}
