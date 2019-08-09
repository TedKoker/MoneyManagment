using Microsoft.AspNetCore.Identity;
using MoneyManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyManagment.Data
{
    public class RoleCreation
    {
        public static async Task Initialize (ApplicationDbContext context, UserManager<ApplicationUser>userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            string role = "Mamber";
            string description = "Can user the acount managment functions";

            if (await roleManager.FindByNameAsync(role) == null)
                await roleManager.CreateAsync(new ApplicationRole(role, description, DateTime.Now));

            /*string[] roles = { "Member" };
            string[] roleDescriptions = { "" };

            for(int i=0; i<roles.Length; i++)
            {
                if (await roleManager.FindByNameAsync(roles[i]) == null)
                    await roleManager.CreateAsync(new ApplicationRole(roles[i], roleDescriptions[i], DateTime.Now));
            }*/
        }
    }
}
