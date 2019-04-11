using Eco_Colocation.ViewModel;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			AllViewModel allViewModel = new AllViewModel();

			return View(allViewModel);
		}

		public ActionResult TypeRecherche(AllViewModel allViewModel)
		{
			TempData["allViewModel"] = allViewModel;

			if (allViewModel.HomeViewModel.TypeRecherche == "searching")
			{
				return RedirectToAction("Index", "SearchColoc", null);
			}
			else
			{
				return RedirectToAction("Index", "ColocAnnounce", null);
			}
			//return View("~/Views/Home/Index.cshtml", allViewModel);
		}
	}
}