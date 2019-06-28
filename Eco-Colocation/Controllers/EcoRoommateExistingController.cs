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

		public ActionResult AddYourEcoRoommateExisting()
		{
			return View();
		}

		public ActionResult ValidAddYourEcoRoommateExisting()
		{
			//faire en sort que si l'admin est connecté. Alors nul besoin de remplir de compte eco-coloc.
			return View();
		}

		public ActionResult ModifiyYourEcoRoommateExisting()
		{
			return View("~/Views/EcoRoommateExisting/AddYourEcoRoommateExisting.cshtml");
		}

		public ActionResult EcoRoommateExistingVisual()
		{
			return View();
		}

		public ActionResult ModalChooseExistingVisual()
		{
			return PartialView();
		}
	}
}