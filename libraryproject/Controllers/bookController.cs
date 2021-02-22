using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace libraryproject.Controllers
{
    public class bookController : Controller
    {
        // GET: book
        public ActionResult book()
        {
            return View();
        }
    }
}