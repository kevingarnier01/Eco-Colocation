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
			AllViewModel allViewModel = new AllViewModel();
			allViewModel.PeopleSearchingViewModel = new PeopleSearchingViewModel();


			PeopleSearchingViewModel peopleSearching = new PeopleSearchingViewModel();
			for (int i = 0; i < 6; i++)
			{
				peopleSearching.IdPeopleSearching = i;
				allViewModel.PeopleSearchingViewModel.LstPeopleSearchingVM.Add(peopleSearching);
			}

			if (currentTab != null && currentTab.Length != 0)
			{
				ViewData["currentTab"] = currentTab;
			}
			else
			{
				ViewData["currentTab"] = "AnnonceLocation";
			}
			ViewData["idModalToTrigger"] = idModal;
			
			allViewModel.HomeViewModel.TypeRecherche = "offering";
			allViewModel.ColocAnnounceViewModel = new ColocAnnounceViewModel();

			return View(allViewModel);
		}

		public ActionResult ModalLocation(string modalByInscription)
		{
			if (modalByInscription != null)
			{
				ViewData["modalByInscription"] = modalByInscription;
			}

			ViewData["targetCity"] = "Rennes";

			return PartialView();
		}

		public ActionResult ModalProjetCreation(string modalByInscription)
		{
			if (modalByInscription != null)
			{
				ViewData["modalByInscription"] = modalByInscription;
			}

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