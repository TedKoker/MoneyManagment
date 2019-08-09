using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyManagment.Models
{
    public class UserInfo
    {
        
        public UserInfo() { }
       [Key]
        public int InfoID { get; set; }
        public DateTime Date { get; set; }
        public string ExpenderOrIncome { get; set; }
        public string FurtherInformation { get; set; }
        public int Sum { get; set; }
        public string Type { get; set; }

        public string Id { get; set; }
        public ApplicationUser User { get; set; }

        public UserInfo(DateTime time, string expenderOrIncome, string furtherInformation
            ,int sum, string type, string id)
        {
            Date = time;
            ExpenderOrIncome = expenderOrIncome;
            FurtherInformation = furtherInformation;
            Sum = sum;
            Type = type;
            Id = id;
        }
        
    }
}
