using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web.Mvc;
using System.Diagnostics;

namespace Services
{
    public class LogAction : ActionFilterAttribute
    {
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			Debug.Write("Test Log " + filterContext.RouteData, "Action Fillter Log");
			
		}
	}
}
