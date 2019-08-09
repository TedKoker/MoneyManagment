using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoneyManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyManagment.Data
{
    public class DeveloperUsersAndData
    {
        static string UserId;
        public static async Task InitializeUsersAndRoles(ApplicationDbContext context, UserManager<ApplicationUser> userManager
            , RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            string memberRole = "Member";
            string memberRoleDescription = "Can see his acount only";

            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(memberRole) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(memberRole, memberRoleDescription, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("tedkol1992@gmail.com") == null)
            {
                var user = new ApplicationUser
                {
                    Email="tedkol1992@gmail.com",
                    UserName= "tedkol1992@gmail.com",
                    FirstName ="Ted",
                    LastName="Kolker",
                    City="Givatayim"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, memberRole);
                }

                
            }
        }

        public static void InizializeUsersInfo(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                if (context.UsersIndo.Any())
                    return;

                List<UserInfo> informationList = DeveloperUsersAndData.GetUsersInfo(context).ToList<UserInfo>();
                context.UsersIndo.AddRange(informationList);
                context.SaveChanges();
            }
        }

        public static void InizializeReasonsForExpenderAndIncome(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                if (context.ResonsForExpenderAndIncome.Any())
                    return;

                List<ResonsForExpenderAndIncome> listOfResons = DeveloperUsersAndData.GetResons(context).ToList<ResonsForExpenderAndIncome>();
                context.ResonsForExpenderAndIncome.AddRange(listOfResons);
                context.SaveChanges();
            }
        }

        public static List<ResonsForExpenderAndIncome> GetResons(ApplicationDbContext context)
        {
            var userId = context.Users.Where(u => u.Email == "tedkol1992@gmail.com").Select(u => u.Id).FirstOrDefault();

            List<ResonsForExpenderAndIncome> listOfResons = new List<ResonsForExpenderAndIncome>()
            {
                new ResonsForExpenderAndIncome
                {
                    ResonForExpenderOrIncome="Income",
                    TheReason="salery",
                    Id = context.Users.Find(userId).Id
                },
                new ResonsForExpenderAndIncome
                {
                    ResonForExpenderOrIncome="Income",
                    TheReason="bonus",
                    Id = context.Users.Find(userId).Id
                },
                new ResonsForExpenderAndIncome
                {
                    ResonForExpenderOrIncome="Expender",
                    TheReason="food",
                    Id = context.Users.Find(userId).Id
                },
                new ResonsForExpenderAndIncome
                {
                    ResonForExpenderOrIncome="Income",
                    TheReason="birthday",
                    Id = context.Users.Find(userId).Id
                },
                new ResonsForExpenderAndIncome
                {
                    ResonForExpenderOrIncome="Expender",
                    TheReason="bills",
                    Id = context.Users.Find(userId).Id
                }
            };

            return listOfResons;
        }

        private static List<UserInfo> GetUsersInfo (ApplicationDbContext context)
        {
            var a = context.Users.Where(u => u.Email == "tedkol1992@gmail.com").Select(u => u.Id).FirstOrDefault();     
            List<UserInfo> ListOfInformation = new List<UserInfo>
            {

                new UserInfo
                {
                    Date = new DateTime(2019,5,23),
                    ExpenderOrIncome = "Income",
                    FurtherInformation = "No",
                    Id = context.Users.Find(a).Id,
                    Sum = 100
                },

                new UserInfo
                {
                    Date = new DateTime(2019,5,27),
                    ExpenderOrIncome = "Income",
                    FurtherInformation = "No",
                    Id = context.Users.Find(a).Id,
                    Sum = 758
                },

                new UserInfo
                {
                    Date = new DateTime(2019,6,23),
                    ExpenderOrIncome = "Expender",
                    FurtherInformation = "No",
                    Id = context.Users.Find(a).Id,
                    Sum = 500
                },

                new UserInfo
                {
                    Date = new DateTime(2019,7,23),
                    ExpenderOrIncome = "Income",
                    FurtherInformation = "No",
                    Id = context.Users.Find(a).Id,
                    Sum = 128
                },

                new UserInfo
                {
                    Date = new DateTime(2019,7,1),
                    ExpenderOrIncome = "Expender",
                    FurtherInformation = "No",
                    Id = context.Users.Find(a).Id,
                    Sum = 1056
                },
            };

            return ListOfInformation;
        }
    }
}
