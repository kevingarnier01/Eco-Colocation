using Eco_Colocation.BLL;
using Eco_Colocation.BO;
using Eco_Colocation.DAL;
using Eco_Colocation.ViewModel;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;

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

			return Redirect(urlCurrentPage);
		}

		public ActionResult ModalAccount()
		{
			return PartialView();
		}
		
		public ActionResult Inscription()
		{

			return View();
		}

		public ActionResult Connection(AccountViewModel accountViewModel)
		{
			UserBo userBo = new UserBo();
			userBo.Email = accountViewModel.UserBo.Email;

			//WebSecurity.CreateUserAndAccount(
			//			model.UserName,
			//			model.Password,
			//			new { FirstName = model.FirstName, LastName = model.LastName, Email = model.Email },
			//			false
			//		);

			return View("~/Views/EcoRoommateHome/EcoRoommateHomeView.cshtml");
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