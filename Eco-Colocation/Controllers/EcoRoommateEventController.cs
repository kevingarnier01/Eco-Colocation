﻿using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
    public class EcoRoommateEventController : Controller
    {
        // GET: EcoRoommateEvent
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult AddYourEcoRoommateEvent()
		{
			return View();
		}

		public ActionResult ModalEcoRoommateEventVisual()
		{
			return PartialView();
		}
		public ActionResult ModalDeleteEcoRoommateEvent()
		{
			return PartialView();
		}

		public ActionResult ModalGoingOrInterested()
		{
			return PartialView();
		}
	}
}