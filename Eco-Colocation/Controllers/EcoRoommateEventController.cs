using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

		public ActionResult EcoRoommateEventVisual()
		{
			return View();
		}
		public ActionResult ModalDeleteEcoRoommateEvent()
		{
			return PartialView();
		}
	}
}