using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace libraryproject.filters
{
    public class AuthorizedUser : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filtercontext)
        {
            if (HttpContext.Current.Session["Islogin"] == null)
            {

                filtercontext.Result = new System.Web.Mvc.RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                {
                    {"Area", "" },
                { "controller", "login" },
                    { "Action", "login" }
                     });

            }
            base.OnActionExecuting(filtercontext);
        }

    }

}