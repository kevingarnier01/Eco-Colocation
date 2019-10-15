using System.Web.Mvc;
using Eco_Colocation.ViewModel;

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
		
		public ActionResult ModalEcoRoommateEventVisual(string idModal)
		{
			EcoRoommateEventViewModel EcoRoommateEventViewModel = new EcoRoommateEventViewModel();
			EcoRoommateEventViewModel.Id = 2;

			ViewData["idModal"] = idModal;

			return PartialView();
		}

		public ActionResult ModalDeleteEcoRoommateEvent()
		{
			return PartialView("~/Views/EcoRoommateEvent/ModalDeleteEcoRoommateEvent.cshtml");
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