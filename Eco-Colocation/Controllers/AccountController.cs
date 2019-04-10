using System.Web.Mvc;
using System.Web.Security;

namespace Eco_Colocation.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult ModalAccount()
		{
			return PartialView();
		}

		public void Connection()
		{
			FormsAuthentication.SignOut();
			HttpContext.User =
				new System.Security.Principal.GenericPrincipal(new System.Security.Principal.GenericIdentity(string.Empty), null);
			FormsAuthentication.SetAuthCookie("User", true);

			//return View("~/Views/Home/Index.cshtml");
		}

		public ActionResult ModalCreateAccount()
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
			return View("~/Views/Home/Index.cshtml");
		}
	}
}