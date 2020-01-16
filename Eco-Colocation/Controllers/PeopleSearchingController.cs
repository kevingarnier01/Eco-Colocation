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

		public ActionResult AddUpd_ModalPeopleSearch(string operation, string idModal)
		{
			ViewData["idModal"] = idModal;
			ViewData["targetCity"] = "Rennes";

			if (operation != null)
			{
				ViewData["operation"] = operation;
			}

			AllViewModel allViewModel = new AllViewModel();

			return PartialView(allViewModel);
		}
		
		//[HttpPost]
		//[MultiSubmitAttribute(Name = "action", Argument = "Valid_AddAndSubscribe")]
		public ActionResult Valid_AddAndSubscribe(AllViewModel AllVM)
		{
			if (ModelState.IsValid)
			{
				AccountController accountController = new AccountController();
				int idPerson = accountController._Inscription(AllVM);

				if (idPerson != 0 && ModelState.IsValid)
				{
					Add(AllVM.PeopleSearchingVM, idPerson);

					ViewData["titlePopup"] = "Inscription et publication d'une annonce";
					ViewData["textPopup"] = "Votre inscription et votre annonce de recherche ont bien été réalisées.";

					return PartialView("~/Views/Shared/CommunPage/Read_ModalPopupAddUpd.cshtml");
				}
			}

			@ViewData["ModalState"] = false;
			ViewData["operation"] = "Subscribe";
			return PartialView("~/Views/PeopleSearching/AddUpd_ModalPeopleSearch.cshtml", AllVM);
		}

		public ActionResult Valid_AddToUser(AllViewModel AllVM)
		{
			if (ModelState.IsValid)
			{
				FormsAuthenticationTicket ticket = (HttpContext.User.Identity as FormsIdentity).Ticket;
				int idUser = Convert.ToInt32(ticket.UserData);
				PersonBo personBo = personManager.GetByUserId(idUser);

				if (personBo.IdPerson != 0 && ModelState.IsValid)
				{
					Add(AllVM.PeopleSearchingVM, personBo.IdPerson);

					ViewData["titlePopup"] = "Publication d'une annonce de recherche";
					ViewData["textPopup"] = "Votre annonce de recherche a bien été créée.";

					return PartialView("~/Views/Shared/CommunPage/Read_ModalPopupAddUpd.cshtml");
				}
			}

			@ViewData["ModalState"] = false;
			ViewData["operation"] = "Subscribe";
			return PartialView("~/Views/PeopleSearching/AddUpd_ModalPeopleSearch.cshtml", AllVM);
		}

		public ActionResult Valid_AddAndConnect(AllViewModel AllVM)
		{
			return View();
		}
		
		[HttpPost]
		[MultiSubmitAttribute(Name = "action", Argument = "Valid_Update")]
		public ActionResult Valid_Update(AllViewModel AllVM)
		{
			return View("");
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

		public void Add(PeopleSearchingViewModel peopleSearchingVM, int idPerson)
		{
			int idResearchRoommate = researchRoommateManager.Add(peopleSearchingVM.ResearchRoommateBo, idPerson);

			for (int i = 0; i < peopleSearchingVM.LstPlaceBo.Count; i++)
			{
				JObject place = JsonConvert.DeserializeObject<JObject>(peopleSearchingVM.LstPlaceBo[i].JsonDataPlace);

				PlaceBo placeBo = new PlaceBo(true);
				if (peopleSearchingVM.PlaceBo.ScopeResearch == (int)ScoopResearch.Commune)
				{
					placeBo.City = (string)place["label"];
					placeBo.PostalCode = (string)place["postcode"];
					string[] context = place["context"].ToString().Split(',');
					if (context != null)
					{
						placeBo.DepartmentNumber = context[0];
						placeBo.Department = context[1];
						placeBo.Region = context[2];
					}
				}
				else if (peopleSearchingVM.PlaceBo.ScopeResearch == (int)ScoopResearch.Departement)
				{
					placeBo.Department = (string)place["nom"];
					placeBo.DepartmentNumber = (string)place["code"];
				}
				else if (peopleSearchingVM.PlaceBo.ScopeResearch == (int)ScoopResearch.Region)
				{
					placeBo.Region = (string)place["nom"];
				}

				placeBo.ScopeResearch = peopleSearchingVM.PlaceBo.ScopeResearch;

				int idPlace = placeManager.Add(placeBo, idResearchRoommate, 0);
			}
		}
	}
}