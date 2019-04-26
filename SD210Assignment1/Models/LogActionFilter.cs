using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SD210Assignment1.Models
{
    public class LogActionFilter : ActionFilterAttribute
    {
        private Stopwatch Stopwatch { get; set; }

        public LogActionFilter()
        {
            Stopwatch = new Stopwatch();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Stopwatch.Reset();
            Stopwatch.Start();
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Stopwatch.Stop();

            var actionLog = new ActionLog
            {
                ActionName = filterContext.ActionDescriptor.ActionName,
                ControllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                TimeInMs = Stopwatch.ElapsedMilliseconds
            };

            var dbContext = new ApplicationDbContext();
            dbContext.Logs.Add(actionLog);
            dbContext.SaveChanges();
        }
    }
}