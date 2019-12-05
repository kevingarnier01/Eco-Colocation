using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
    public class Ad_CreationProjectController : Controller
    {
        // GET: Ad_CreationProject
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult AddUpd_ModalCreationProjectAd(string modalByInscription)
		{
			if (modalByInscription != null)
			{
				ViewData["modalByInscription"] = modalByInscription;
			}

			return PartialView();
		}

		public ActionResult Del_MsgModalCreationProjectAd()
		{
			return PartialView();
		}
		
		public ActionResult Read_ModalCreationProjectAd(string idModal)
		{
			ViewData["targetCity"] = "Rennes";
			ViewData["IdModal"] = idModal;

			return PartialView();
		}

		public ActionResult DeleteProjectCreation()
		{
			//** A faire : Supprimer l'annonce **//

			return RedirectToAction("CommonAd", "Home", new { currentTab = "ProjetCreation", researchType = "offering" });
		}
	}
}