using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MoneyManagment.Data;
using MoneyManagment.Models;

namespace MoneyManagment.Controllers
{
    [Authorize(Roles ="Member")]
    public class PersonalController : Controller
    {
        private readonly ApplicationDbContext Context;
        private readonly UserManager<ApplicationUser> UserManager;

        public PersonalController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            Context = context;
            UserManager = userManager;
        }

        public IActionResult Index(int? mounth, int? year)
        {
            int totalBlance = 0;

            if (mounth == null)
                mounth = DateTime.Now.Month;
            if (year == null)
                year = DateTime.Now.Year;
            string correntUserId= UserManager.GetUserId(HttpContext.User);
            List<UserInfo> listOfAll = new List<UserInfo>();
            foreach (UserInfo info in Context.UsersIndo.Where(u => u.Id == correntUserId).Where(u => u.Date.Month == mounth).Where(u => u.Date.Year == year))
            {
                listOfAll.Add(info);
            }
            foreach(UserInfo item in listOfAll)
            {
                if (item.ExpenderOrIncome.ToLower() == "income")
                    totalBlance += item.Sum;
                else
                    totalBlance -= item.Sum;
            }
            ViewBag.totalBlance = totalBlance;
            ViewBag.listOfAll = listOfAll;
            ViewBag.dateMounth = mounth;
            ViewBag.dateYear = year;
            return View();
        }

        public IActionResult NewItem(DateTime date, string expenderOrIncome,string furtherInformation
            , int sum, string type)
        {
            if (date == null)
                date = DateTime.Now;
            UserInfo newInfo = new UserInfo()
            {
                Date = date,
                ExpenderOrIncome=expenderOrIncome,
                FurtherInformation=furtherInformation,
                Sum=sum,
                Type=type,
                Id= UserManager.GetUserId(HttpContext.User)
            };

            Context.UsersIndo.Add(newInfo);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        /*This Controler is not relevvent any more....
         * 
         * public IActionResult AddNewInfo()
        {
            ViewBag.Expender = Context.ResonsForExpenderAndIncome.Where(x => x.ResonForExpenderOrIncome.ToLower() == "expender").ToList<ResonsForExpenderAndIncome>();
            ViewBag.Income = Context.ResonsForExpenderAndIncome.Where(x => x.ResonForExpenderOrIncome.ToLower() == "income").ToList<ResonsForExpenderAndIncome>();
            return View();
        }*/

        public IActionResult ExpenderList()
        {
            string correntUserId = UserManager.GetUserId(HttpContext.User);
            return Ok(Context.ResonsForExpenderAndIncome.Where(x => x.ResonForExpenderOrIncome.ToLower() == "expender").Where(x=>x.Id==correntUserId).ToList<ResonsForExpenderAndIncome>());
        }

        public IActionResult IncomeList()
        {
            string correntUserId = UserManager.GetUserId(HttpContext.User);
            return Ok(Context.ResonsForExpenderAndIncome.Where(x => x.ResonForExpenderOrIncome.ToLower() == "income").Where(x => x.Id == correntUserId).ToList<ResonsForExpenderAndIncome>());
        }

        public IActionResult newOfAddingInfo()
        {
            return View();
        }

        public IActionResult DeleteFromUserrInfo(int infoId)
        {
            UserInfo infoToRemove = Context.UsersIndo.Where(x => x.InfoID == infoId).FirstOrDefault();
            Context.UsersIndo.Remove(infoToRemove);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AddToReasonsList(string reson, string expenderOrIncome)
        {
            ResonsForExpenderAndIncome newReson = new ResonsForExpenderAndIncome()
            {
                ResonForExpenderOrIncome = expenderOrIncome,
                TheReason=reson,
                Id= UserManager.GetUserId(HttpContext.User)
            };
            Context.ResonsForExpenderAndIncome.Add(newReson);
            Context.SaveChanges();
            return RedirectToAction("newOfAddingInfo");
        }
    }
}