using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
    public class PeopleSearchingController : Controller
    {
        // GET: PeopleSearching
        public ActionResult Index()
        {
            return View();
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