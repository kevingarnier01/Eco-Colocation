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

        public ActionResult SearchColoc(AllViewModel allViewModel)
        {
            return View("~/Views/Home/Index.cshtml", allViewModel);
        }
    }
}