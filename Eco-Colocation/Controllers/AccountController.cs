using Eco_Colocation.BLL;
using Eco_Colocation.DAL;
using Eco_Colocation.ViewModel;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;
using static Eco_Colocation.App_Start._Enums;

namespace Eco_Colocation.Controllers
{
	public class AccountController : BaseController
	{
		private UserManager UserManager { get; set; }
		private PersonManager PersonManager { get; set; }

		public AccountController()
		{
			UserSql userSql = new UserSql(base.WebDbSqlConnectionString);
			PersonSql personSql = new PersonSql(base.WebDbSqlConnectionString);

			this.UserManager = new UserManager(userSql);
			this.PersonManager = new PersonManager(personSql);
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
			_Inscription(allVM);

			return View();
		}

		public int _Inscription(AllViewModel allVM)
		{
			int idPerson = 0;

			if (ModelState.IsValid)
			{
				bool userExist = WebSecurity.UserExists(allVM.AccountVM.UserBo.UserName);

				if (userExist == false)
				{
					WebSecurity.CreateUserAndAccount(
								allVM.AccountVM.UserBo.UserName,
								allVM.AccountVM.UserBo.Password,
								new
								{
									TypeUser = 1,
									Activated = 1
								},
								false
							);

					allVM.AccountVM.UserBo.IdUser = WebSecurity.GetUserId(allVM.AccountVM.UserBo.UserName);

					if (allVM.AccountVM.UserBo.TypeUser != (int)TypeUser.Agence)
					{
						idPerson = PersonManager.Add(allVM.AccountVM.UserBo.PersonBo, allVM.AccountVM.UserBo.IdUser);
					}

					if (idPerson != 0)
						Connection(allVM);
				}
				else
				{
					ModelState.AddModelError("Email", "Cet utilisateur existe déja. S'il vous plait entrez un email différent.");
				}
			}


			return idPerson;
		}

		public ActionResult Connection(AllViewModel AllViewModel)
		{
			//FormsAuthentication.SetAuthCookie("User", true);
			AllViewModel.AccountVM.UserBo.IdUser = WebSecurity.GetUserId(AllViewModel.AccountVM.UserBo.UserName);
			if (AllViewModel.AccountVM.UserBo.IdUser != 0)
			{
				string username = "User";
				bool isPersistent = false;
				FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
				  1,
				  "User",
				  DateTime.Now,
				  DateTime.Now.AddMinutes(30),
				  isPersistent,
				  Convert.ToString(AllViewModel.AccountVM.UserBo.IdUser),
				  FormsAuthentication.FormsCookiePath);

				// Encrypt the ticket.
				string encTicket = FormsAuthentication.Encrypt(ticket);

				// Create the cookie.
				Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

				var a = FormsAuthentication.GetRedirectUrl(username, isPersistent);

				// Redirect back to original URL.
				return Redirect(FormsAuthentication.GetRedirectUrl(username, isPersistent));
			}
			return View();
			//return View("~/Views/EcoRoommateHome/EcoRoommateHomeView.cshtml");
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