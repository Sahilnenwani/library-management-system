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
    public class studentController : Controller
    {
        // GET: student
        //[HttpGet]
        public ActionResult createstudent()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult createstudent()
        //{
        //    return View();
        //}
        
        //[HttpGet]
        public ActionResult ViewStudent()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult ViewStudent()
        //{
        //    return View();
        //}


        //[HttpGet]
        public ActionResult updateStudent()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult updateStudent()
        //{
        //    return View();
        //}


        //[HttpGet]
        public ActionResult deleteStudent()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult deleteStudent()
        //{
        //    return View();
        //}

    }
}