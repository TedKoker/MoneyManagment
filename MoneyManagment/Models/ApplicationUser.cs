using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyManagment.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public List<UserInfo> UserInformation { get; set; }
        public List<ResonsForExpenderAndIncome> UsersIncomeAndExpenderReasons { get; set; }
        
    }
}
