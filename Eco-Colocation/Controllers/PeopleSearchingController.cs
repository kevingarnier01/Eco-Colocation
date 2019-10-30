using Eco_Colocation.ViewModel;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class PeopleSearchingController : Controller
	{
		// GET: PeopleSearching
		public ActionResult Index()
		{
			AllViewModel allVM = new AllViewModel();
			allVM.PeopleSearchingViewModel = new PeopleSearchingViewModel();
			allVM.PeopleSearchingViewModel.LstPeopleSearchingVM = new List<PeopleSearchingViewModel>();
			
			PeopleSearchingViewModel peopleSearchingVM2 = new PeopleSearchingViewModel();

			for (int i = 0; i < 6; i++)
			{
				peopleSearchingVM2.IdPeopleSearching = i;
				allVM.PeopleSearchingViewModel.LstPeopleSearchingVM.Add(peopleSearchingVM2);
			}

			return View(allVM);
		}

		public ActionResult ModalPeopleSearch(string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			return PartialView();
		}

		public ActionResult ModalUpdateDataProfil(string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			return PartialView("~/Views/PeopleSearching/ModalUpdateDataProfil.cshtml");
		}

		public ActionResult HtmlAnnoncePeople()
		{
			AllViewModel allVM = new AllViewModel();
			allVM.PeopleSearchingViewModel = new PeopleSearchingViewModel();

			Random rnd = new Random();
			int id = rnd.Next(100, 200);

			allVM.PeopleSearchingViewModel.IdPeopleSearching = id;

			return PartialView(allVM);
		}
	}
}