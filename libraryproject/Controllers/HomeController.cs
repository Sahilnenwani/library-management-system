using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using libraryproject.filters;

namespace libraryproject.Controllers
{
    [Authorize]
    [AuthorizedUser]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult logout()

        {
            Session.Clear();
            return RedirectToAction("login", "login");
        }
    }
}