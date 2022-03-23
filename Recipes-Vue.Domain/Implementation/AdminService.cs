using Microsoft.AspNetCore.Identity;
using Recipes_Vue.Database.DbContext;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Implementation
{
    public class AdminService : IAdminService
    {
        protected readonly RecipesDbContext _dbContext;

        public AdminService(RecipesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public bool CreateNewRoleAsync(IdentityRole indentityRole)
        {
            throw new NotImplementedException();
        }

        public CreateUserResponse CreateUserAsync(CreateUserRequest createUserRequest)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoleAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public bool EditRoleAsync(string roleId, string roleNewName)
        {
            throw new NotImplementedException();
        }

        public bool EditUserAsync(string userId, EditUserRequest editUserRequest)
        {
            throw new NotImplementedException();
        }

        public IList<IdentityRole> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public IList<UserDetailsResponse> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public IdentityRole GetRoleByIdAsync(string roleId)
        {
            throw new NotImplementedException();
        }

        public UserDetailsResponse GetUserByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
