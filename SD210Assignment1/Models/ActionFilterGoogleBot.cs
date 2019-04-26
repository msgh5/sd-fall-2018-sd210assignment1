using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SD210Assignment1.Models
{
    public class ActionFilterGoogleBot : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var isGoogleBot = filterContext.HttpContext.Request.UserAgent == "googlebot";

            if (isGoogleBot)
            {
                filterContext.Result = new EmptyResult();
            }
        }
    }
}