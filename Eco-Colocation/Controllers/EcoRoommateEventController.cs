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
		public ActionResult AddUpd_EcoRoommateEvent(string operation)
		{
			if (operation != null)
			{
				ViewData["operation"] = operation;
			}

			return View();
		}

		public ActionResult Read_ModalEcoRoommateEvent(string idModal)
		{
			EcoRoommateEventViewModel EcoRoommateEventViewModel = new EcoRoommateEventViewModel();
			EcoRoommateEventViewModel.Id = 2;

			ViewData["idModal"] = idModal;

			return PartialView();
		}

		public ActionResult Del_MsgModalEcoRoommateEvent()
		{
			return PartialView("~/Views/EcoRoommateEvent/Del_MsgModalEcoRoommateEvent.cshtml");
		}

		public ActionResult ModalGoingOrInterested()
		{
			return PartialView();
		}

		public ActionResult AddPublication()
		{
			return PartialView("~/Views/EcoRoommateEvent/Read_ModalEcoRoommateEvent.cshtml");
		}
	}
}