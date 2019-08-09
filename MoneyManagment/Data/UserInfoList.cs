using MoneyManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyManagment.Data
{
    public static class UserInfoList
    {
        public static List<UserInfo> correntList { get; set; }

        static UserInfoList()
        {
            correntList = new List<UserInfo>();
        }
    }
}
