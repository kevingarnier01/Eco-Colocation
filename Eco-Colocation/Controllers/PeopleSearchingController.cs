﻿using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
    public class PeopleSearchingController : Controller
    {
        // GET: PeopleSearching
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult ModalPeopleSearch()
		{
			return PartialView();
		}

	}
}