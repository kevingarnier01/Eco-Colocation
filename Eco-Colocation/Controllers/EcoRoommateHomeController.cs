using Eco_Colocation.ViewModel;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class EcoRoommateHomeController : Controller
	{
		public ActionResult EcoRoommateHomeView()
		{
			AllViewModel allViewModel = new AllViewModel();

			PeopleSearchingViewModel peopleSearching = new PeopleSearchingViewModel(true);
			allViewModel.PeopleSearchingVM = peopleSearching;

			for (int i = 0; i < 6; i++)
			{
				peopleSearching = new PeopleSearchingViewModel(true);
				peopleSearching.IdPeopleSearching = i;
				allViewModel.PeopleSearchingVM.LstPeopleSearchingVM.Add(peopleSearching);
			}

			return View(allViewModel);
		}

		public ActionResult TypeRecherche(AllViewModel allViewModel)
		{
			TempData["allViewModel"] = allViewModel;

			return RedirectToAction("CommonAd", new { researchType = allViewModel.EcoRoommateVM.TypeRecherche });
		}

		public ActionResult CommonAd(string currentTab, string researchType, string operation)
		{
			AllViewModel allViewModel = new AllViewModel();
			allViewModel.PeopleSearchingVM = new PeopleSearchingViewModel(true);

			PeopleSearchingViewModel peopleSearching = new PeopleSearchingViewModel(true);
			for (int i = 0; i < 6; i++)
			{
				peopleSearching.IdPeopleSearching = i;
				allViewModel.PeopleSearchingVM.LstPeopleSearchingVM.Add(peopleSearching);
			}

			if (currentTab != null && currentTab.Length != 0)
			{
				ViewData["currentTab"] = currentTab;
			}
			else
			{
				ViewData["currentTab"] = "AnnonceLocation";
			}
			
			ViewData["researchType"] = (researchType != null) ? researchType : "searching";

			ViewData["operation"] = (operation != null) ? operation : "operation";

			return View("~/Views/Ad_Common/RubriqueAd.cshtml", allViewModel);
		}
	}
}