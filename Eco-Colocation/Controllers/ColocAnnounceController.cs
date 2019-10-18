using System.Web.Mvc;
using System.Web.Security;
using Eco_Colocation.ViewModel;

namespace Eco_Colocation.Controllers
{
	public class ColocAnnounceController : Controller
	{
		// GET: ColocAnnounce
		public ActionResult Index(string currentTab, string idModal)
		{
			if (currentTab != null && currentTab.Length != 0)
			{
				ViewData["currentTab"] = currentTab;
			}
			else
			{
				ViewData["currentTab"] = "AnnonceLocation";
			}
			ViewData["idModalToTrigger"] = idModal;

			AllViewModel allViewModel = new AllViewModel();
			allViewModel.HomeViewModel.TypeRecherche = "offering";
			allViewModel.ColocAnnounceViewModel = new ColocAnnounceViewModel();

			return View(allViewModel);
		}

		public ActionResult ModalLocation()
		{
			ViewData["targetCity"] = "Rennes";

			return PartialView();
		}

		public ActionResult ModalProjetCreation()
		{
			return PartialView();
		}

		public ActionResult ModalUpdateProjetCreation()
		{
			AllViewModel allViewModel = new AllViewModel();

			return PartialView("~/Views/ColocAnnounce/ModalProjetCreation.cshtml", allViewModel);
		}

		public ActionResult ModalUpdateLocation()
		{
			AllViewModel allViewModel = new AllViewModel();

			return PartialView("~/Views/ColocAnnounce/ModalLocation.cshtml", allViewModel);
		}

		public ActionResult ModalDeleteProjetCreation()
		{
			return PartialView();
		}

		public ActionResult DeleteProjetCreation()
		{
			//** A faire : Supprimer l'annonce **//

			return RedirectToAction("ProjetCreation", "ColocAnnounce", null);
		}

		public ActionResult ProjetCreation(string targetCity)
		{
			ViewData["currentTab"] = "ProjetCreation";
			ViewData["showProjetCreation"] = "true";

			AllViewModel allViewModel = new AllViewModel();

			return View("~/Views/ColocAnnounce/Index.cshtml", allViewModel);
		}

		public ActionResult AnnonceLocation(string targetCity)
		{
			ViewData["showAnnonceLocation"] = "true";

			AllViewModel allViewModel = new AllViewModel();

			return View("~/Views/ColocAnnounce/Index.cshtml", allViewModel);
		}

		public ActionResult ModalDeleteLocation()
		{
			return PartialView();
		}

		public ActionResult DeleteLocation()
		{
			return RedirectToAction("AnnonceLocation", "ColocAnnounce", null);
		}
	}
}