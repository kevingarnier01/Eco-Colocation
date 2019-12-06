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
			TempData["idModalToTrigger"] = "#modalConnectionLink";

			return View("~/Views/EcoRoommateHome/EcoRoommateHomeView.cshtml");
		}

		public ActionResult ModalInscription()
		{
			TempData["idModalToTrigger"] = "#modalInscriptionLink";

			return View("~/Views/EcoRoommateHome/EcoRoommateHomeView.cshtml");
		}

		[HttpGet]
		public ActionResult ModalCreateEmptyAccount()
		{
			TempData["idModalToTrigger"] = "#createEmptyAccountLing-h";

			return View("~/Views/EcoRoommateHome/EcoRoommateHomeView.cshtml");
		}

		[HttpGet]
		public ActionResult Read_ModalPeopleSearch(string idModal, string targetCity)
		{
			TempData["idModalToTrigger"] = "#peopleSearchingLink-" + idModal;

			AllViewModel allViewModel = new AllViewModel();
			allViewModel.PeopleSearchingViewModel = new PeopleSearchingViewModel();


			PeopleSearchingViewModel peopleSearching = new PeopleSearchingViewModel();
			for (int i = 0; i < 6; i++)
			{
				peopleSearching.IdPeopleSearching = i;
				allViewModel.PeopleSearchingViewModel.LstPeopleSearchingVM.Add(peopleSearching);
			}

			return View("~/Views/PeopleSearching/PeopleSearchingView.cshtml", allViewModel);
		}

		[HttpGet]
		public ActionResult AddUpd_ModalPeopleSearch()
		{
			TempData["idModalToTrigger"] = "#addSearchingAnnonceLink-ps";

			return View("~/Views/EcoRoommateHome/EcoRoommateHomeView.cshtml");
		}

		[HttpGet]
		public ActionResult AddUpd_ModalPeopleSearchUpdate(string idModal, string targetCity)
		{
			TempData["idModalToTrigger"] = "#peopleSearchingUpdateLink-" + idModal;

			return View("~/Views/PeopleSearching/PeopleSearchingView.cshtml");
		}

		[HttpGet]
		public ActionResult Read_ModalEcoRoommateEvent(string idModal)
		{

			TempData["idModalToTrigger"] = "#ecoRoommateEventLink-" + idModal;

			return View("~/Views/EcoRoommateHome/EcoRoommateHomeView.cshtml");
		}

		[HttpGet]
		public ActionResult Read_ModalRentalAd(string targetCity, string idModal, string urlCurrentPage, string researchType)
		{
			AllViewModel allViewModel = new AllViewModel();
			//...Recuperer les données necessaire en fonction de la veriable targetCity qui représente la ville qu'il à saisi

			TempData["idModalToTrigger"] = "#annonceLocationPVLink-" + idModal;
			string currentTab = "AnnonceLocation";

			if (urlCurrentPage != null && urlCurrentPage.Length != 0)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&researchType=" + researchType);
			}
			else
			{
				return RedirectToAction("CommonAd", "EcoRoommateHome", new { @currentTab = "AnnonceLocation" });
			}
		}

		[HttpGet]
		public ActionResult AddUpd_ModalRentalAd(string targetCity, string urlCurrentPage, string researchType, string modalByInscription)
		{
			AllViewModel allViewModel = new AllViewModel();

			if (modalByInscription == "true")
			{
				return ModalInscription();
			}

			TempData["idModalToTrigger"] = ".createAnnounceLocationLink-al";

			string currentTab = "AnnonceLocation";

			if (urlCurrentPage.Length != 0 && modalByInscription == null)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&researchType=" + researchType);
			}
			else
			{
				return RedirectToAction("CommonAd", "EcoRoommateHome", new { @currentTab = "ProjetCreation", @researchType = "offering" });
			}
		}

		[HttpGet]
		public ActionResult Read_ModalCreationProjectAd(string targetCity, string idModal, string urlCurrentPage, string researchType)
		{
			AllViewModel allViewModel = new AllViewModel();
			//...Recuperer les données necessaire en fonction de la veriable targetCity qui représente la ville qu'il à saisi

			TempData["idModalToTrigger"] = "#projetCreationPVLink-" + idModal;
			string currentTab = "ProjetCreation";

			if (urlCurrentPage.Length != 0)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&researchType=" + researchType);
			}
			else
			{
				return RedirectToAction("CommonAd", "EcoRoommateHome", new { @currentTab = "AnnonceLocation" });
			}
		}

		[HttpGet]
		public ActionResult AddUpd_ModalCreationProjectAd(string targetCity, string urlCurrentPage, string researchType, string modalByInscription)
		{
			AllViewModel allViewModel = new AllViewModel();

			if (modalByInscription == "true")
			{
				return ModalInscription();
			}

			TempData["idModalToTrigger"] = ".createProjetCreationLink-al";
			string currentTab = "ProjetCreation";

			if (urlCurrentPage.Length != 0)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&researchType=" + researchType);
			}
			else
			{
				return RedirectToAction("CommonAd", "EcoRoommateHome", new { @currentTab = "ProjetCreation", @researchType = "offering" });
			}
		}
	}
}