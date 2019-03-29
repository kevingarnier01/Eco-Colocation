using System.Web.Mvc;
using System.Web.Security;
using Eco_Colocation.ViewModel;

namespace Eco_Colocation.Controllers
{
	public class ColocAnnounceController : Controller
	{
		// GET: ColocAnnounce
		public ActionResult Index()
		{
			AllViewModel allViewModel = new AllViewModel
			{
				ColocAnnounceViewModel = new ColocAnnounceViewModel()
			};
			return View("~/Views/Home/Index.cshtml", allViewModel);
		}

		public ActionResult ModalLocation()
		{
			//bool userIsConnect = false;
			//FormsAuthentication.GetAuthCookie("User", userIsConnect);
			//if (userIsConnect)
			//{
			return PartialView();
			//}
			//else
			//{
			//return PartialView("~/Views/Account/ModalAccount.cshtml");
			//}
		}

		public ActionResult ModalProjetCreation()
		{

			return PartialView();

			//bool userIsConnect = false;
			//FormsAuthentication.GetAuthCookie("User", userIsConnect);
			//if (userIsConnect)
			//{
			//	return PartialView();
			//}
			//else
			//{
			//	return PartialView("~/Views/Account/ModalAccount.cshtml");
			//}
		}
	}
}