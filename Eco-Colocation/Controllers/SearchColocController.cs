﻿using Eco_Colocation.ViewModel;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class SearchColocController : Controller
	{
		// GET: SearchColoc
		public ActionResult Index(/*AllViewModel allViewModel*/)
		{
			AllViewModel allViewModel = new AllViewModel();

			return View(allViewModel);

			//return View("~/Views/Home/Index.cshtml", allViewModel);
		}

		public PartialViewResult ModalLocation(string id)
		{
			return PartialView();
		}

		public PartialViewResult ModalSendMessage()
		{
			return PartialView();
		}

		public PartialViewResult ModalProjetCreation()
		{
			return PartialView();
		}
	}
}