using Eco_Colocation.ViewModel;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class EcoRoommateHomeController : Controller
	{
		public ActionResult EcoRoommateHomeView()
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

			return RedirectToAction("CommonAd", new { researchType = allViewModel.EcoRoommateHome.TypeRecherche });
		}

		public ActionResult CommonAd(string currentTab, string researchType)
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
			
			ViewData["researchType"] = (researchType != null) ? researchType : "searching";

			return View("~/Views/Ad_Common/RubriqueAd.cshtml", allViewModel);
		}
	}
}