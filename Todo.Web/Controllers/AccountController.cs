using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Todo.Web.Controllers
{
	[RoutePrefix("compte")]
	public class AccountController : Controller
    {
        // GET: Account
		[HttpPost]
		[Route("Controle")]
        public ActionResult Login(string pNom, string returnUrl)
        {
			if(pNom == "Rochet")
			{
				FormsAuthentication.SetAuthCookie(pNom, true);
				return Redirect(returnUrl);
			}

			return View(pNom);
		}
    }
}