using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoneyManagment.Models;

namespace MoneyManagment.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserInfo> UsersIndo { get; set; }
        public DbSet<ResonsForExpenderAndIncome> ResonsForExpenderAndIncome { get; set; }
    }
}
