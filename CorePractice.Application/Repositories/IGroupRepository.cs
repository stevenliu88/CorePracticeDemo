using CorePractice.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CorePractice.Application.Repositories
{
    interface IGroupRepository
    {
        Task<Group> GetGroupByIdAsync(int groupId);
        Task InsertGroupAsync(Group group);
        Task UpdateGroupAsync(Group group);
        Task DeleteGroupByIdAsync(int groupId);
    }
}
