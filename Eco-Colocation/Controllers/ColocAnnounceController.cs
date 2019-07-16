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
		}

		public ActionResult AnnonceLocation(string targetCity)
		{
			ViewData["showAnnonceLocation"] = "true";

			AllViewModel allViewModel = new AllViewModel();

			return View("~/Views/ColocAnnounce/Index.cshtml", allViewModel);
		}

		public ActionResult ProjetCreation(string targetCity)
		{
			ViewData["showProjetCreation"] = "true";

			AllViewModel allViewModel = new AllViewModel();

			return View("~/Views/ColocAnnounce/Index.cshtml", allViewModel);
		}
	}
}