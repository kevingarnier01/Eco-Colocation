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

		public ActionResult ModalEcoRoommateEventVisual()
		{
			return PartialView();
		}
		public ActionResult ModalDeleteEcoRoommateEvent()
		{
			return View("~/Views/EcoRoommateEvent/AddYourEcoRoommateEvent.cshtml");
		}

		public ActionResult ModalGoingOrInterested()
		{
			return PartialView();
		}

		public ActionResult AddPublication()
		{
			return PartialView("~/Views/EcoRoommateEvent/ModalEcoRoommateEventVisual.cshtml");
		}
	}
}