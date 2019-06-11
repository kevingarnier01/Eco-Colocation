using System.Web.Mvc;
using System.Web.Security;

namespace Eco_Colocation.Controllers
{
	public class AccountController : Controller
	{
		// GET: Account
		public ActionResult Index()
		{
			FormsAuthentication.SetAuthCookie("User", true);
			return Redirect(Request.UrlReferrer.PathAndQuery);

			//return RedirectToAction("Index", "Home", null);
		}

		public ActionResult ModalAccount()
		{
			return PartialView();
		}

		public ActionResult Deconnection()
		{
			FormsAuthentication.SignOut();
			HttpContext.User =
				new System.Security.Principal.GenericPrincipal(new System.Security.Principal.GenericIdentity(string.Empty), null);

			return RedirectToAction("Index", "Home", null);
			//return View("~/Views/Home/Index.csthml");
		}

		public ActionResult ModalCreateAccount()
		{
			return PartialView();
		}

		public ActionResult ModalCreateEmptyAccount()
		{
			return PartialView();
		}

		public ActionResult ModalCAPropose()
		{
			return PartialView();
		}

		public ActionResult ModalCARecherche()
		{
			return PartialView();
		}

		public ActionResult FindAccountByEmail()
		{
			return View("~/Views/Account/ForgetAccount/FindAccountByEmail.cshtml");
		}

		public ActionResult SendCode()
		{
			return View("~/Views/Account/ForgetAccount/SendCode.cshtml");
		}

		public ActionResult CheckCodeSend()
		{
			return View("~/Views/Account/ForgetAccount/CheckCodeSend.cshtml");
		}
		public ActionResult ChangePassword()
		{
			return View("~/Views/Account/ForgetAccount/ChangePassword.cshtml");
		}

		public ActionResult ChangePasswordFinish()
		{
			return View("~/Views/Home/Index.cshtml");
		}
	}
}