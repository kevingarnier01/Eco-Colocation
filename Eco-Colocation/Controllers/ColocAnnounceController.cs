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
			AllViewModel allViewModel = new AllViewModel();
			allViewModel.ColocAnnounceViewModel = new ColocAnnounceViewModel();

			return View(allViewModel);
		}

		public ActionResult ModalLocation()
		{
			return PartialView();
		}

		public ActionResult ModalProjetCreation()
		{
			return PartialView();

			//if (User.Identity.IsAuthenticated)
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