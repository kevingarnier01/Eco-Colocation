using Eco_Colocation.ViewModel;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class ProfilController : Controller
	{
		// GET: Profil
		public ActionResult Index()
		{
			return View();
		}
		
		public ActionResult AnnouncementsAndProjects()
		{
			AllViewModel allViewModel = new AllViewModel();
			allViewModel.ColocAnnounceViewModel = new ColocAnnounceViewModel();

			ViewData["changeTitle"] = "true";

			return View("~/Views/ColocAnnounce/Index.cshtml", allViewModel);
		}
	}
}