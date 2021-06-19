﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreatLines_v1.DAL.Entities;

namespace TreatLines_v1.DAL.Repositories
{
    public class UserRepository
    {
        private readonly UserManager<User> userManager;

        //private readonly DbContext context;

        public UserRepository(
            UserManager<User> userManager
            //DbContext context
            )
        {
            this.userManager = userManager;
            //this.context = context;
        }

        public async Task<IdentityResult> TryCreateAsync(User user, string password)
        {
            var addingResult = await userManager.CreateAsync(user, password);
            return addingResult;
        }

        public async Task AddUserToRoleAsync(User user, string role)
        {
            await userManager.AddToRoleAsync(user, role);
        }

        public Task<bool> CheckPasswordAsync(User user, string password)
        {
            return userManager.CheckPasswordAsync(user, password);
        }

        public Task<User> FindByEmailAsync(string email)
        {
            return userManager.FindByEmailAsync(email);
        }

        public Task<IList<string>> GetRolesAsync(User user)
        {
            return userManager.GetRolesAsync(user);
        }

        public Task<IList<User>> GetUsersInRoleAsync(string roleName)
        {
            return userManager.GetUsersInRoleAsync(roleName);
        }

        public async Task UpdateAsync(User user)
        {
            await userManager.UpdateAsync(user);
        }

        public async Task DeleteAsync(User user)
        {
            await userManager.DeleteAsync(user);
        }

        /*public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }*/
    }
}
