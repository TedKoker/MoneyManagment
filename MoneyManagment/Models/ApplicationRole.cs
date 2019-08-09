using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyManagment.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName):base(roleName) { }
        public ApplicationRole(string roleName, string description, DateTime dateOfCreation) : base (roleName)
        {
            Description = description;
            DateOfCreation = dateOfCreation;
        }
        public string Description { get; }
        public DateTime DateOfCreation { get; }

    }
}
