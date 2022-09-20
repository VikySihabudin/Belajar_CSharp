using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BELAJAR_CSHARP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckUpass(string fname, string Pass)
        {
            if (fname == "admin" && Pass == "admin")
            {
                return RedirectToAction("About", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

    }
}