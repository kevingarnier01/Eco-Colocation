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