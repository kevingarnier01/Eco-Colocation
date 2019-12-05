using Eco_Colocation.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class ModalController : Controller
	{
		// GET: Modal
		public ActionResult Index()
		{
			return View();
		}


		[HttpGet]
		public ActionResult ModalConnection()
		{
			ViewData["idModalToTrigger"] = "#modalConnectionLink";

			return View("~/Views/Home/Index.cshtml");
		}

		public ActionResult ModalInscription()
		{
			ViewData["idModalToTrigger"] = "#modalInscriptionLink";

			return View("~/Views/Home/Index.cshtml");
		}
				
		[HttpGet]
		public ActionResult ModalCreateEmptyAccount()
		{
			ViewData["idModalToTrigger"] = "#createEmptyAccountLing-h";

			return View("~/Views/Home/Index.cshtml");
		}

		[HttpGet]
		public ActionResult Read_ModalPeopleSearch(string idModal, string targetCity)
		{
			ViewData["idModalToTrigger"] = "#peopleSearchingLink-" + idModal;

			AllViewModel allViewModel = new AllViewModel();
			allViewModel.PeopleSearchingViewModel = new PeopleSearchingViewModel();


			PeopleSearchingViewModel peopleSearching = new PeopleSearchingViewModel();
			for (int i = 0; i < 6; i++)
			{
				peopleSearching.IdPeopleSearching = i;
				allViewModel.PeopleSearchingViewModel.LstPeopleSearchingVM.Add(peopleSearching);
			}

			return View("~/Views/PeopleSearching/Index.cshtml", allViewModel);
		}

		[HttpGet]
		public ActionResult AddUpd_ModalPeopleSearch()
		{
			ViewData["idModalToTrigger"] = "#addSearchingAnnonceLink-ps";

			return View("~/Views/home/Index.cshtml");
		}

		[HttpGet]
		public ActionResult AddUpd_ModalPeopleSearchUpdate(string idModal, string targetCity)
		{
			ViewData["idModalToTrigger"] = "#peopleSearchingUpdateLink-" + idModal;

			return View("~/Views/PeopleSearching/Index.cshtml");
		}

		[HttpGet]
		public ActionResult Read_ModalEcoRoommateEvent(string idModal)
		{

			ViewData["idModalToTrigger"] = "#ecoRoommateEventLink-" + idModal;

			return View("~/Views/Home/Index.cshtml");
		}

		[HttpGet]
		public ActionResult Read_ModalRentalAd(string targetCity, string idModal, string urlCurrentPage, string researchType)
		{
			AllViewModel allViewModel = new AllViewModel();
			//...Recuperer les données necessaire en fonction de la veriable targetCity qui représente la ville qu'il à saisi

			string idModalDestination = "#annonceLocationPVLink-" + idModal;
			string currentTab = "AnnonceLocation";

			if (urlCurrentPage != null && urlCurrentPage.Length != 0)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&researchType=" + researchType + "&idModal=" + Uri.EscapeDataString(idModalDestination));
			}
			else
			{
				return RedirectToAction("CommonAd", "Home", new { @currentTab = "AnnonceLocation" });
			}
		}

		[HttpGet]
		public ActionResult AddUpd_ModalRentalAd(string targetCity, string urlCurrentPage, string researchType)
		{
			AllViewModel allViewModel = new AllViewModel();

			string idModalDestination = ".createAnnounceLocationLink-al";
			string currentTab = "AnnonceLocation";

			if (urlCurrentPage.Length != 0)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&researchType=" + researchType + "&idModal=" + Uri.EscapeDataString(idModalDestination));
			}
			else
			{
				return RedirectToAction("CommonAd", "Home", new { @currentTab = "ProjetCreation", @researchType = "offering"});
			}
		}

		[HttpGet]
		public ActionResult Read_ModalCreationProjectAd(string targetCity, string idModal, string urlCurrentPage, string researchType)
		{
			AllViewModel allViewModel = new AllViewModel();
			//...Recuperer les données necessaire en fonction de la veriable targetCity qui représente la ville qu'il à saisi

			string idModalDestination = "#projetCreationPVLink-" + idModal;
			string currentTab = "ProjetCreation";

			if (urlCurrentPage.Length != 0)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&researchType=" + researchType + "&idModal=" + Uri.EscapeDataString(idModalDestination));
			}
			else
			{
				return RedirectToAction("CommonAd", "Home", new { @currentTab = "AnnonceLocation" });
			}
		}

		[HttpGet]
		public ActionResult AddUpd_ModalCreationProjectAd(string targetCity, string urlCurrentPage, string researchType)
		{
			AllViewModel allViewModel = new AllViewModel();

			string idModalDestination = ".createProjetCreationLink-al";
			string currentTab = "ProjetCreation";

			if (urlCurrentPage.Length != 0)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&researchType=" + researchType + "&idModal=" + Uri.EscapeDataString(idModalDestination));
			}
			else
			{
				return RedirectToAction("CommonAd", "Home", new { @currentTab = "ProjetCreation", @researchType = "offering" });
			}
		}
	}
}