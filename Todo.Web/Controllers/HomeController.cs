using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services;

namespace Todo.Web.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		
		[LogAction]
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			return View();
		}
	}
}
