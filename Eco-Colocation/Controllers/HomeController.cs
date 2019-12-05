using Eco_Colocation.ViewModel;
using System;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			AllViewModel allViewModel = new AllViewModel();
			allViewModel.PeopleSearchingViewModel = new PeopleSearchingViewModel();

			for (int i = 0; i < 6; i++)
			{
				PeopleSearchingViewModel peopleSearching = new PeopleSearchingViewModel();
				peopleSearching.IdPeopleSearching = i;
				allViewModel.PeopleSearchingViewModel.LstPeopleSearchingVM.Add(peopleSearching);
			}

			return View(allViewModel);
		}

		public ActionResult TypeRecherche(AllViewModel allViewModel)
		{
			TempData["allViewModel"] = allViewModel;

			return RedirectToAction("CommonAd", new { researchType = allViewModel.HomeViewModel.TypeRecherche });
		}

		public ActionResult CommonAd(string currentTab, string idModal, string researchType)
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

			ViewData["researchType"] = (researchType != null) ? researchType : "searching";

			return View("~/Views/Ad_Common/RubriqueAd.cshtml", allViewModel);
		}
	}
}