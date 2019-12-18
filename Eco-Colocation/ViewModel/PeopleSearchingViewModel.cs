using Eco_Colocation.App_Start;
using Eco_Colocation.BO;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Eco_Colocation.ViewModel
{
	public class PeopleSearchingViewModel
    {
		public PlaceBo PlaceBo { get; set; }

		public List<PeopleSearchingViewModel> LstPeopleSearchingVM { get; set; }
		public int IdPeopleSearching { get; set; }
		public SelectList ScoopResearchLst { get; set; }

		public PeopleSearchingViewModel() { }
		public PeopleSearchingViewModel(bool init)
		{
			if (init == true)
			{
				PlaceBo = new PlaceBo();

				LstPeopleSearchingVM = new List<PeopleSearchingViewModel>();
				IdPeopleSearching = new int();
			}
		}

		public void InitLst()
		{
			_Lists _Lists = new _Lists();
			ScoopResearchLst = _Lists.ScoopResearchLst();
		}
	}
}