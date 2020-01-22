using Eco_Colocation.App_Start;
using Eco_Colocation.BLL;
using Eco_Colocation.BO;
using Eco_Colocation.DAL;
using Eco_Colocation.ViewModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;
using static Eco_Colocation.App_Start._Enums;

namespace Eco_Colocation.Controllers
{
	public class PeopleSearchingController : BaseController
	{
		private ResearchRoommateManager researchRoommateManager { get; set; }
		private PlaceManager placeManager { get; set; }
		private PersonManager personManager { get; set; }

		public PeopleSearchingController()
		{
			ResearchRoommateSql researchRoommateSql = new ResearchRoommateSql(base.WebDbSqlConnectionString);
			this.researchRoommateManager = new ResearchRoommateManager(researchRoommateSql);

			PlaceSql placeSql = new PlaceSql(base.WebDbSqlConnectionString);
			this.placeManager = new PlaceManager(placeSql);

			PersonSql personSql = new PersonSql(base.WebDbSqlConnectionString);
			this.personManager = new PersonManager(personSql);
		}

		// GET: PeopleSearching
		public ActionResult PeopleSearchingView()
		{
			AllViewModel allVM = new AllViewModel();
			allVM.PeopleSearchingVM = new PeopleSearchingViewModel(true);
			allVM.PeopleSearchingVM.LstPeopleSearchingVM = new List<PeopleSearchingViewModel>();

			PeopleSearchingViewModel peopleSearchingVM2 = new PeopleSearchingViewModel(true);

			for (int i = 0; i < 6; i++)
			{
				peopleSearchingVM2.IdPeopleSearching = i;
				allVM.PeopleSearchingVM.LstPeopleSearchingVM.Add(peopleSearchingVM2);
			}

			return View(allVM);
		}
			   
		public ActionResult DisplayInputSearchPlace(string jsonDataPlace, string scopeResearch)
		{
			PlaceBo placeBo = new _InputSearchPlace().GetObjectFromPlaceJson(jsonDataPlace, Convert.ToInt32(scopeResearch));

			AllViewModel allViewModel = new AllViewModel();
			allViewModel.PeopleSearchingVM = new PeopleSearchingViewModel(true);
			allViewModel.PeopleSearchingVM.LstPlaceBo.Add(placeBo);

			return View("~/Views/PeopleSearching/AddUpd_ModalPeopleSearch.cshtml", allViewModel);
		}

		public ActionResult AddUpd_ModalPeopleSearch(string operation, string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			if (operation != null)
			{
				ViewData["operation"] = operation;
			}

			AllViewModel allViewModel = new AllViewModel();

			if (operation == "Update")
			{
				allViewModel = GetDataUser();
			}

			return PartialView(allViewModel);
		}

		//[HttpPost]
		//[MultiSubmitAttribute(Name = "action", Argument = "Valid_AddAndSubscribe")]
		/// <summary>
		/// Creation d'un compte en plus d'une annonce de recherche
		/// </summary>
		/// <param name="AllVM"></param>
		/// <returns></returns>
		public ActionResult Valid_AddAndSubscribe(AllViewModel AllVM)
		{
			if (ModelState.IsValid)
			{
				AccountController accountController = new AccountController();
				int idPerson = accountController._Inscription(AllVM);

				if (idPerson != 0 && ModelState.IsValid)
				{
					AddOrUpdate(AllVM.PeopleSearchingVM, idPerson, (int)TypeOperation.Add);

					ViewData["titlePopup"] = "Inscription et publication d'une annonce";
					ViewData["textPopup"] = "Votre inscription et votre annonce de recherche ont bien été réalisées.";

					return PartialView("~/Views/Shared/CommunPage/Read_ModalPopupAddUpd.cshtml");
				}
			}

			@ViewData["ModalState"] = false;
			ViewData["operation"] = "Subscribe";
			return PartialView("~/Views/PeopleSearching/AddUpd_ModalPeopleSearch.cshtml", AllVM);
		}

		/// <summary>
		/// L'utilisteur à déja un compte et souhaite creer une annonce de recherche
		/// </summary>
		/// <param name="AllVM"></param>
		/// <returns></returns>
		public ActionResult Valid_AddToUser(AllViewModel AllVM)
		{
			//Probleme, le modelState recupere les nom & prénom 
			if (ModelState.IsValid)
			{
				int idUser = new AccountController().GetIdUserFromCookieConnection(HttpContext);
				PersonBo personBo = personManager.GetByUserId(idUser);

				if (personBo.IdPerson != 0 && ModelState.IsValid)
				{
					AddOrUpdate(AllVM.PeopleSearchingVM, personBo.IdPerson, (int)TypeOperation.Add);

					ViewData["titlePopup"] = "Publication d'une annonce de recherche";
					ViewData["textPopup"] = "Votre annonce de recherche a bien été créée.";

					return PartialView("~/Views/Shared/CommunPage/Read_ModalPopupAddUpd.cshtml");
				}
			}

			@ViewData["ModalState"] = false;
			ViewData["operation"] = "Subscribe";
			return PartialView("~/Views/PeopleSearching/AddUpd_ModalPeopleSearch.cshtml", AllVM);
		}

		//[HttpPost]
		//[MultiSubmitAttribute(Name = "action", Argument = "Valid_Update")]
		/// <summary>
		/// L'utilisateur souhaite mettre à jour son annonce de recherche
		/// </summary>
		/// <param name="AllVM"></param>
		/// <returns></returns>
		public ActionResult Valid_Update(AllViewModel AllVM)
		{
			if (ModelState.IsValid)
			{
				FormsAuthenticationTicket ticket = (HttpContext.User.Identity as FormsIdentity).Ticket;
				int idUser = Convert.ToInt32(ticket.UserData);
				PersonBo personBo = personManager.GetByUserId(idUser);

				if (personBo.IdPerson != 0 && ModelState.IsValid)
				{
					AddOrUpdate(AllVM.PeopleSearchingVM, personBo.IdPerson, (int)TypeOperation.Update);

					ViewData["titlePopup"] = "Publication d'une annonce de recherche";
					ViewData["textPopup"] = "Votre annonce de recherche a bien été créée.";

					return PartialView("~/Views/Shared/CommunPage/Read_ModalPopupAddUpd.cshtml");
				}
			}

			@ViewData["ModalState"] = false;
			ViewData["operation"] = "Subscribe";
			return PartialView("~/Views/PeopleSearching/AddUpd_ModalPeopleSearch.cshtml", AllVM);
		}

		public ActionResult Read_ModalPeopleSearch(string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			return PartialView();
		}

		public ActionResult HtmlAnnoncePeople()
		{
			AllViewModel allVM = new AllViewModel();
			allVM.PeopleSearchingVM = new PeopleSearchingViewModel(true);

			Random rnd = new Random();
			int id = rnd.Next(100, 200);

			allVM.PeopleSearchingVM.IdPeopleSearching = id;

			return PartialView(allVM);
		}

		public void AddOrUpdate(PeopleSearchingViewModel peopleSearchingVM, int idPerson, int operation)
		{
			int idResearchRoommate = 0;

			if (operation == (int)TypeOperation.Add)
				idResearchRoommate = researchRoommateManager.Add(peopleSearchingVM.ResearchRoommateBo, idPerson);
			else if (operation == (int)TypeOperation.Update)
				idResearchRoommate = researchRoommateManager.Upd(peopleSearchingVM.ResearchRoommateBo, idPerson);

			for (int i = 0; i < peopleSearchingVM.LstPlaceBo.Count; i++)
			{
				PlaceBo placeBo = new _InputSearchPlace().GetObjectFromPlaceJson(peopleSearchingVM.LstPlaceBo[i].JsonDataPlace, peopleSearchingVM.PlaceBo.ScopeResearch);

				placeBo.ScopeResearch = peopleSearchingVM.PlaceBo.ScopeResearch;

				if (operation == (int)TypeOperation.Add)
				{
					int idPlace = placeManager.Add(placeBo, idResearchRoommate, 0);
				}
				else if (operation == (int)TypeOperation.Update)
				{
					bool valid = placeManager.Upd(placeBo, idResearchRoommate, 0);
				}
			}
		}

		public AllViewModel GetDataUser()
		{
			int idUser = new AccountController().GetIdUserFromCookieConnection(HttpContext);
			PersonBo personBo = personManager.GetByUserId(idUser);

			AllViewModel allViewModel = new AllViewModel();
			allViewModel.PeopleSearchingVM = new PeopleSearchingViewModel();

			allViewModel.PeopleSearchingVM.ResearchRoommateBo = researchRoommateManager.GetByPersonId(personBo.IdPerson);
			allViewModel.PeopleSearchingVM.LstPlaceBo = placeManager.GetByResearchRoommateId(allViewModel.PeopleSearchingVM.ResearchRoommateBo.IdResearchRoommate);

			return allViewModel;
		}
	}
}