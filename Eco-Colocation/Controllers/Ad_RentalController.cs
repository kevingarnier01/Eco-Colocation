using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

		public ActionResult AddUpd_ModalRentalAd(string modalByInscription)
		{
			if (modalByInscription != null)
			{
				ViewData["modalByInscription"] = modalByInscription;
			}

			ViewData["targetCity"] = "Rennes";

			return PartialView();
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