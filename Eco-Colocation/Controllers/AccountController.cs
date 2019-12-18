using Eco_Colocation.BLL;
using Eco_Colocation.DAL;
using Eco_Colocation.ViewModel;
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
			AllViewModel allViewModel = new AllViewModel();

			return PartialView(allViewModel);
		}

		public ActionResult Inscription(AllViewModel allVM)
		{
			if (ModelState.IsValid)
			{
				WebSecurity.CreateUserAndAccount(
							allVM.AccountVM.UserBo.UserName,
							allVM.AccountVM.UserBo.MembershipBo.Password,
							new
							{
								TypeUser = 1,
								Activated = 1
							},
							false
						);
			}

			return View();
		}

		public ActionResult Connection(AccountViewModel accountViewModel)
		{
			FormsAuthentication.SetAuthCookie("User", true);

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

		public ActionResult AddUpd_ModalPeopleSearch(string operation)
		{
			ViewData["operation"] = operation;

			return PartialView();
		}

		public ActionResult ModalCreateEmptyAccount()
		{
			AllViewModel allVM = new AllViewModel();
			allVM.AccountVM = new AccountViewModel(true);

			return PartialView(allVM);
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