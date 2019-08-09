using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyManagment.Models
{
    public class ResonsForExpenderAndIncome
    {
        /*
         This table is collecting all the reasons that any users put himself for his expender and cost
         onle column is says what is the resons, another one says is it expender or income, and the last one 
         shows what is the Id of the users that added it to the database.
         */

        [Key]
        public int ReasonsId { get; set; }
        public string ResonForExpenderOrIncome { get; set; }//the column says if the reason belongs to the expender list or the income list
        public string TheReason { get; set; }//the column says what is the reason for the expender/income

        public string Id { get; set; }
        public ApplicationUser User { get; set; }
    }
}
