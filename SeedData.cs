﻿namespace CrimsonDev.Gameteki.Data
{
    using System.Linq;
    using System.Threading.Tasks;
    using CrimsonDev.Gameteki.Data.Constants;
    using CrimsonDev.Gameteki.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    public class SeedData
    {
        public static Task Initialize(IServiceScope scope, GametekiDbContext context)
        {
            return CheckAndAddRoles(scope, context);
        }

        private static async Task CheckAndAddRoles(IServiceScope scope, GametekiDbContext context)
        {
            var roles = new[]
            {
                Roles.UserManager, Roles.NewsManager, Roles.GameManager, Roles.PermissionsManager, Roles.NodeManager, Roles.ChatManager
            };

            foreach (var role in roles)
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<GametekiRole>>();
                if (!context.Roles.Any(r => r.Name == role))
                {
                    await roleManager.CreateAsync(new GametekiRole(role));
                }
            }
        }
    }
}