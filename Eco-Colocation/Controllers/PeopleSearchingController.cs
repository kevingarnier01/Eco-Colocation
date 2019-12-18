using Eco_Colocation.ViewModel;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class PeopleSearchingController : Controller
	{
		// GET: PeopleSearching
		public ActionResult PeopleSearchingView()
		{
			AllViewModel allVM = new AllViewModel();
			allVM.PeopleSearchingVM = new PeopleSearchingViewModel(true);
			allVM.PeopleSearchingVM.LstPeopleSearchingVM = new List<PeopleSearchingViewModel>();

			PeopleSearchingViewModel peopleSearchingVM2 = new PeopleSearchingViewModel(true);

			for (int i = 0; i < 6; i++)
			{
				peopleSearchingVM2.IdPeopleSearching = i;
				allVM.PeopleSearchingVM.LstPeopleSearchingVM.Add(peopleSearchingVM2);
			}

			return View(allVM);
		}

		public ActionResult AddUpd_ModalPeopleSearch(string operation, string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			if (operation != null)
			{
				ViewData["operation"] = operation;
			}

			AllViewModel allViewModel = new AllViewModel();

			return PartialView(allViewModel);
		}

		[HttpPost]
		[MultiButton(Name = "action", Argument = "Valid_Add")]
		public ActionResult Valid_Add(AllViewModel AllVM)
		{
			return View("");
		}

		[HttpPost]
		[MultiButton(Name = "action", Argument = "Valid_AddAndSubscribe")]
		public ActionResult Valid_AddAndSubscribe(AllViewModel AllVM)
		{
			return View("");
		}

		[HttpPost]
		[MultiButton(Name = "action", Argument = "Valid_AddAndConnect")]
		public ActionResult Valid_AddAndConnect(AllViewModel AllVM)
		{
			return View("");
		}

	   [HttpPost]
		[MultiButton(Name = "action", Argument = "Valid_Update")]
		public ActionResult Valid_Update(AllViewModel AllVM)
		{
			return View("");
		}

		public ActionResult Read_ModalPeopleSearch(string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			return PartialView();
		}

		public ActionResult HtmlAnnoncePeople()
		{
			AllViewModel allVM = new AllViewModel();
			allVM.PeopleSearchingVM = new PeopleSearchingViewModel(true);

			Random rnd = new Random();
			int id = rnd.Next(100, 200);

			allVM.PeopleSearchingVM.IdPeopleSearching = id;

			return PartialView(allVM);
		}	

		public bool Add(PeopleSearchingViewModel PeopleSearchingVM)
		{
			return true;
		}
	}
}