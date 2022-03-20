using Microsoft.AspNetCore.Identity;
using Recipes_Vue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Interfaces
{
    public interface IAdminService
    {
        IList<UserDetailsResponse> GetAllUsersAsync();
        UserDetailsResponse GetUserByIdAsync(string userId);
        CreateUserResponse CreateUserAsync(CreateUserRequest createUserRequest);
        bool EditUserAsync(string userId, EditUserRequest editUserRequest);
        bool DeleteUserAsync(string userId);

        // roles
        IList<IdentityRole> GetAllRoles();
        IdentityRole GetRoleByIdAsync(string roleId);
        bool CreateNewRoleAsync(IdentityRole indentityRole);
        bool EditRoleAsync(string roleId, string roleNewName);
        bool DeleteRoleAsync(string roleId);
    }
}
