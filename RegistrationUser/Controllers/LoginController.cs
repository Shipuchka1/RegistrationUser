using Company.Register.Lib;
using Company.Register.Lib.Model;
using RegistrationUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationUser.Controllers
{
    public class LoginController : Controller
    {
        Model1 db = new Model1();
        // GET: Login
        public ActionResult Index(MyUser us)

        {
            us.AddressLegal = new Company.Register.Lib.Model.Address() { CityId = 1, ContryId = 3, House = "76", Street = "kkkk" };
            us.AddressPhysical = new Company.Register.Lib.Model.Address() { CityId = 1, ContryId = 3, House = "76", Street = "kkkk" };
            us.BankDetails[0] = new BankDetail() { AccountNumber = "", Bik = "", CurrencyId = 1 };
            us.ContactNumbers[0] = new Company.Register.Lib.Model.Phone() { PhoneCode = "777", PhoneNumber = "77777777", PhoneTypeId = 1, СountryСode = "7" };

            if (ModelState.IsValid)
            {
TempData.Add("User", us);
                return RedirectToAction("Success");
            }
                
            else
                return View();
        }

        public ActionResult Success()
        {
            MyUser user = (MyUser)TempData["User"];
            ViewBag.Message = CompanyRegisterService.RegisterContractors((UserAccount)user);
            return View();
        }
    }
}