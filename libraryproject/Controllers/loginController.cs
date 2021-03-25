using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using libraryproject.Models;
using System.Web.Mvc;
using System.Web.Security;
namespace libraryproject.Controllers
{
    public class loginController : Controller
    {

        // GET: login
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(loginmodel loginData)
        {
            using(var context= new library_management_systemEntities1())
            {
                bool isvalid = context.logins.Any(x=>x.UserName==loginData.UserName && x.Userpassword == loginData.Userpassword);
                if (isvalid)
                {
                    Session["IsLogin"] = true;
                   
                    FormsAuthentication.SetAuthCookie(loginData.UserName,false);
                    return RedirectToAction("Index","BookTables");
                }
                ModelState.AddModelError("","In Valid UserName or Password");
                return View();

            }
                    
                                     
        }
    }
}