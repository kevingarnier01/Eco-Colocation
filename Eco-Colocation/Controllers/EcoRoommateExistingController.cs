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

		public ActionResult AddYourEcoRoomate()
		{
			return View();
		}

		public ActionResult EcoRoomateExistingVisual()
		{
			return View();
		}
    }
}