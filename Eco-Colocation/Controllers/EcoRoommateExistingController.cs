using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
    public class EcoRoommateExistingController : Controller
    {
        // GET: EcoRoommateExisting
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult AddUpd_EcoRoommateExisting(string operation)
		{
			if (operation != null)
			{
				ViewData["operation"] = operation;
			}

			return View();
		}

		public ActionResult ValidAddUpd_EcoRoommateExisting()
		{
			//faire en sort que si l'admin est connecté. Alors nul besoin de remplir de compte eco-coloc.
			return View();
		}
		
		public ActionResult Read_EcoRoommateExisting()
		{
			return View();
		}

		public ActionResult ModalChooseExistingVisual()
		{
			return PartialView();
		}
	}
}