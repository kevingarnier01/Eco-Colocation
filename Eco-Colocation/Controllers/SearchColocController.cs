using Eco_Colocation.ViewModel;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class SearchColocController : Controller
	{
		// GET: SearchColoc
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
			
			allViewModel.HomeViewModel.TypeRecherche = "searching";

			return View(allViewModel);

			//return View("~/Views/Home/Index.cshtml", allViewModel);
		}

		public PartialViewResult ModalLocation(string idModal)
		{
			ViewData["targetCity"] = "Rennes";
			ViewData["IdModal"] = idModal;

			return PartialView();
		}

		//public PartialViewResult ModalSendMessage()
		//{
		//	return PartialView();
		//}

		public PartialViewResult ModalProjetCreation(string idModal)
		{
			ViewData["targetCity"] = "Rennes";
			ViewData["IdModal"] = idModal;

			return PartialView();
		}
		public ActionResult AnnonceLocation(string targetCity)
		{
			ViewData["showAnnonceLocation"] = "true";

			AllViewModel allViewModel = new AllViewModel();

			return View("~/Views/SearchColoc/Index.cshtml", allViewModel);
		}

		public ActionResult ProjetCreation(string targetCity)
		{
			ViewData["showProjetCreation"] = "true";

			AllViewModel allViewModel = new AllViewModel();

			return View("~/Views/SearchColoc/Index.cshtml", allViewModel);
		}
	}
}