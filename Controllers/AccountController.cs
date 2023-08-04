using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApp.Models.VM;

namespace UserApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult Register(VMRegister register) 
        {
            return View();
         }
    
    
    }

}