﻿using Eco_Colocation.ViewModel;
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
		public ActionResult ModalUpdateDataProfil(string idModal, string targetCity)
		{
			ViewData["idModalToTrigger"] = "#peopleSearchingUpdateLink-" + idModal;

			return View("~/Views/PeopleSearching/Index.cshtml");
		}

		[HttpGet]
		public ActionResult ModalPeopleSearch(string idModal, string targetCity)
		{
			ViewData["idModalToTrigger"] = "#peopleSearchingLink-" + idModal;

			return View("~/Views/PeopleSearching/Index.cshtml");
		}

		[HttpGet]
		public ActionResult ModalCARecherche()
		{
			ViewData["idModalToTrigger"] = "#addSearchingAnnonceLink-ps";

			return View("~/Views/PeopleSearching/Index.cshtml");
		}

		[HttpGet]
		public ActionResult ModalEcoRoommateEventVisual(string idModal)
		{

			ViewData["idModalToTrigger"] = "#ecoRoommateEventLink-" + idModal;

			return View("~/Views/Home/Index.cshtml");
		}

		[HttpGet]
		public ActionResult ModalLocation(string targetCity, string idModal, string urlCurrentPage)
		{
			AllViewModel allViewModel = new AllViewModel();
			//...Recuperer les données necessaire en fonction de la veriable targetCity qui représente la ville qu'il à saisi

			string idModalDestination = "#annonceLocationPVLink-" + idModal;
			string currentTab = "AnnonceLocation";

			if (urlCurrentPage != null && urlCurrentPage.Length != 0)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&idModal=" + Uri.EscapeDataString(idModalDestination));
			}
			else
			{
				return View("~/Views/SearchColoc/Index.cshtml", allViewModel);
			}
		}

		[HttpGet]
		public ActionResult ModalProjetCreation(string targetCity, string idModal, string urlCurrentPage)
		{
			AllViewModel allViewModel = new AllViewModel();
			//...Recuperer les données necessaire en fonction de la veriable targetCity qui représente la ville qu'il à saisi

			string idModalDestination = "#projetCreationPVLink-" + idModal;
			string currentTab = "ProjetCreation";

			if (urlCurrentPage.Length != 0)
			{
				return Redirect(urlCurrentPage + "/?currentTab=" + currentTab + "&idModal=" + Uri.EscapeDataString(idModalDestination));
			}
			else
			{
				return View("~/Views/SearchColoc/Index.cshtml", allViewModel);
			}
		}

		[HttpGet]
		public ActionResult ModalLocation_ColocAnnounce()
		{
			ViewData["idModalToTrigger"] = "#createAnnounceLocationLink-h";

			return View("~/Views/Home/Index.cshtml");
		}

		[HttpGet]
		public ActionResult ModalProjetCreation_ColocAnnounce()
		{
			ViewData["idModalToTrigger"] = "#createProjetCreationLink-h";

			return View("~/Views/Home/Index.cshtml");
		}
		

					[HttpGet]
		public ActionResult ModalCreateEmptyAccount()
		{
			ViewData["idModalToTrigger"] = "#createEmptyAccountLing-h";

			return View("~/Views/Home/Index.cshtml");
		}
	}
}