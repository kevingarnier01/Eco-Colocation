using Eco_Colocation.BLL;
using Eco_Colocation.BO;
using Eco_Colocation.DAL;
using Eco_Colocation.ViewModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	public class PeopleSearchingController : BaseController
	{
		private ResearchRoommateManager researchRoommateManager { get; set; }
		private PlaceManager placeManager { get; set; }

		public PeopleSearchingController()
		{
			ResearchRoommateSql researchRoommateSql = new ResearchRoommateSql(base.WebDbSqlConnectionString);
			this.researchRoommateManager = new ResearchRoommateManager(researchRoommateSql);

			PlaceSql placeSql = new PlaceSql(base.WebDbSqlConnectionString);
			this.placeManager = new PlaceManager(placeSql);
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

		[HttpPost]
		[MultiSubmitAttribute(Name = "action", Argument = "Valid_Add")]
		public ActionResult Valid_Add(AllViewModel AllVM)
		{
			return View("");
		}

		[HttpPost]
		[MultiSubmitAttribute(Name = "action", Argument = "Valid_AddAndSubscribe")]
		public ActionResult Valid_AddAndSubscribe(AllViewModel AllVM)
		{
			AccountController accountController = new AccountController();
			int idPerson = accountController._Inscription(AllVM);

			Add(AllVM.PeopleSearchingVM, idPerson);

			return View("");
		}

		[HttpPost]
		[MultiSubmitAttribute(Name = "action", Argument = "Valid_AddAndConnect")]
		public ActionResult Valid_AddAndConnect(AllViewModel AllVM)
		{
			return View("");
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

		public bool Add(PeopleSearchingViewModel peopleSearchingVM, int idPerson)
		{
			int idResearchRoommate = researchRoommateManager.Add(peopleSearchingVM.ResearchRoommateBo, idPerson);
			
			for (int i = 0; i < peopleSearchingVM.LstPlaceBo.Count; i++)
			{				
				JObject place = JsonConvert.DeserializeObject<JObject>(peopleSearchingVM.LstPlaceBo[i].EntirePlaceName);

				PlaceBo placeBo = new PlaceBo(true);
				if(peopleSearchingVM.PlaceBo.ScopeResearch == 2 || peopleSearchingVM.PlaceBo.ScopeResearch == 3)
				{
					placeBo.Department = (string)place["nom"];
					placeBo.DepartmentNumber = (string)place["code"];
				}
				else { 
				placeBo.City = (string)place["label"];
				placeBo.PostalCode = (string)place["postcode"];
				var context = ((string)place["context"]);
					if (context != null)
					{
						context.Split(',');
						placeBo.DepartmentNumber = context[0].ToString();
						placeBo.Department = context[1].ToString();
						placeBo.Region = context[2].ToString();
						//placeBo.Country;
					}
				}
				placeBo.ScopeResearch = peopleSearchingVM.PlaceBo.ScopeResearch;
								
				int idPlace = placeManager.Add(placeBo, idResearchRoommate, 0);
			}

			return true;
		}
	}
}