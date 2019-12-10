using Eco_Colocation.BLL;
using Eco_Colocation.DAL;
using Eco_Colocation.ViewModel;
using System.Web.Mvc;
using System.Web.Security;
using Eco_Colocation.Models;

namespace Eco_Colocation.Controllers
{
	public class AccountController : BaseController
	{
		private UserManager UserManager { get; set; }

		public AccountController()
		{
			UserSql oUserSql = new UserSql(base.WebDbSqlConnectionString);
			this.UserManager = new UserManager(oUserSql);
		}

		// GET: Account
		public ActionResult Index(string urlCurrentPage)
		{
			FormsAuthentication.SetAuthCookie("User", true);
			//return Redirect(Request.UrlReferrer.PathAndQuery);
			return Redirect(urlCurrentPage);
			//if(urlCurrentPage != "")
			//	return View("~/Views" + urlCurrentPage + ".csthml");
			//else

			//AllViewModel allViewModel = new AllViewModel();
			//return View("~/Views/Home/Index.csthml", allViewModel);
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

			return RedirectToAction("EcoRoommateHomeView", "EcoRoommateHome", null);
			//return View("~/Views/Home/Index.csthml");
		}

		public ActionResult ModalInscriptionWay()
		{
			return PartialView();
		}

		public ActionResult ModalCreateEmptyAccount()
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
			return View("~/Views/EcoRoommateHome/EcoRoommateHomeView.cshtml");
		}
	}
}