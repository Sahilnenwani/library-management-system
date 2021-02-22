using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace libraryproject.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult createstudent()
        {
            return View();
        }
        public ActionResult ManageStudent()
        {
            return View();
        }
    }
}