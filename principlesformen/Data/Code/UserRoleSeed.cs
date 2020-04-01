using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace principlesformen.Data.Code
{
    public static class UserRoleSeed
    {
        public static async Task InitializeAsync(ApplicationDbContext context, IServiceProvider serviceProvider)
        {
            await context.Database.EnsureCreatedAsync();
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = { "Admin", "Author", "GuestAuthor", "User" };

            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExists = await RoleManager.RoleExistsAsync(roleName);

                if (!roleExists)
                {
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}
