using Eco_Colocation.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class PeopleSearchingController : Controller
	{
		// GET: PeopleSearching
		public ActionResult Index()
		{
			PeopleSearchingViewModel peopleSearchingVM = new PeopleSearchingViewModel();

			peopleSearchingVM.LstPeopleSearchingVM = new List<PeopleSearchingViewModel>();
			for (int i = 0; i < 15; i++)
			{
				peopleSearchingVM.IdPeopleSearching = i;
				peopleSearchingVM.LstPeopleSearchingVM.Add(peopleSearchingVM);
			}
			

			return View(peopleSearchingVM);
		}

		public ActionResult ModalPeopleSearch(string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			return PartialView();
		}

		public ActionResult ModalUpdateDataProfil(string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			return PartialView("~/Views/PeopleSearching/ModalUpdateDataProfil.cshtml");
		}
	}
}