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
			FormsAuthentication.SetAuthCookie("User", false);
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
	}
}