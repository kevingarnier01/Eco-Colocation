

namespace Eco_Colocation.ViewModel
{
	public class AllViewModel
	{
		public AllViewModel()
		{
			InitData();
		}

		public EcoRoommateHomeModel EcoRoommateHome { get; set; }
		public PeopleSearchingViewModel PeopleSearchingViewModel { get; set; }

		public void InitData()
		{
			EcoRoommateHome = new EcoRoommateHomeModel();
			PeopleSearchingViewModel = new PeopleSearchingViewModel();
		}
	}
}