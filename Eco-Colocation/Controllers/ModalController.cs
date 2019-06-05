using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
    public class ModalController : Controller
    {
        // GET: Modal
        public ActionResult Index()
        {
            return View();
        }

		[HttpGet]
		public ActionResult ModalEcoRoommateEventVisual(string id)
		{
			ViewData["elementIdToTrigger"] = "#ecoRoommateEventLink-" + id;
			
			return View("~/Views/Home/Index.cshtml");
		}

		[HttpGet]
		public ActionResult ModalLocation(string id)
		{
			ViewData["elementIdToTrigger"] = "#ecoRoommateEventLink-" + id;

			return View("~/Views/SearchColoc/Index.cshtml");
		}
	}
}