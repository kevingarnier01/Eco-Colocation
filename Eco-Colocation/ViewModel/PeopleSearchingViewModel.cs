using Eco_Colocation.App_Start;
using Eco_Colocation.BO;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eco_Colocation.ViewModel
{
	public class PeopleSearchingViewModel
    {
		public PlaceBo PlaceBo { get; set; }
		public ResearchRoommateBo ResearchRoommateBo { get; set; }

		public List<PeopleSearchingViewModel> LstPeopleSearchingVM { get; set; }
		public int IdPeopleSearching { get; set; }
		public SelectList ScopeResearchLst { get; set; }

		[RequiredListMinItems(1, ErrorMessage = "Aucun lieu n'a été renseigné.")]
		public List<PlaceBo> LstPlaceBo { get; set; }

		public List<PlaceBo> LstPlaceBoReferent { get; set; }

		public PeopleSearchingViewModel() { }
		public PeopleSearchingViewModel(bool init)
		{
			if (init == true)
			{
				PlaceBo = new PlaceBo(true);
				ResearchRoommateBo = new ResearchRoommateBo(true);

				LstPeopleSearchingVM = new List<PeopleSearchingViewModel>();
				LstPlaceBo = new List<PlaceBo>();
				IdPeopleSearching = new int();
			}
		}

		public void InitLst()
		{
			_Lists _Lists = new _Lists();
			ScopeResearchLst = _Lists.ScoopResearchLst();
		}
	}
}