﻿using Eco_Colocation.ViewModel;
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

		public ActionResult AddUpd_ModalPeopleSearch(string operation, string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			if (operation != null)
			{
				ViewData["operation"] = operation;
			}

			return PartialView();
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
			allVM.PeopleSearchingViewModel = new PeopleSearchingViewModel();

			Random rnd = new Random();
			int id = rnd.Next(100, 200);

			allVM.PeopleSearchingViewModel.IdPeopleSearching = id;

			return PartialView(allVM);
		}
	}
}