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
        public ActionResult Addbook()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult book()
        //{
        //    return View();
        //}
        
        //[HttpGet]
        public ActionResult Managebook()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Managebook()
        //{
        //    return View();
        //}

        //[HttpGet]
        public ActionResult Issuebook()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Issuebook()
        //{
        //    return View();
        //}


        //[HttpGet]
        public ActionResult Returnbook()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Returnbook()
        //{
        //    return View();
        //}


        //[HttpGet]
        public ActionResult BookFine()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult BookFine()
        //{
        //    return View();
        //}
        //[HttpGet]
        public ActionResult updateBook()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult updateStudent()
        //{
        //    return View();
        //}


        //[HttpGet]
        public ActionResult deleteBook()
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