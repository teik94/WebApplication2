using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginAction(Users u)
        {
            if(u != null)
            {
                //If success
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //If failed
                return View("Login");
            }

        }

    }
}
