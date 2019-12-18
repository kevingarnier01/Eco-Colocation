using Eco_Colocation.ViewModel;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class Ad_RentalController : Controller
	{
		// GET: Ad_Rental
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Read_ModalRentalAd(string idModal)
		{
			ViewData["targetCity"] = "Rennes";
			ViewData["IdModal"] = idModal;

			return PartialView();
		}

		public ActionResult AddUpd_ModalRentalAd(string operation)
		{
			if (operation != null)
			{
				ViewData["operation"] = operation;
			}

			ViewData["targetCity"] = "Rennes";

			AllViewModel AllViewModel = new AllViewModel();

			return PartialView(AllViewModel);
		}

		public ActionResult Del_MsgModalRentalAd()
		{ 
			return PartialView();
		}

		public ActionResult DeleteRentalAd()
		{
			return RedirectToAction("CommonAd", "EcoRoommateHome", new { currentTab = "AnnonceLocation", researchType = "offering" });
		}		
	}
}