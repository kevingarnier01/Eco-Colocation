

namespace Eco_Colocation.ViewModel
{
    public class AllViewModel
    {
        public AllViewModel()
        {
            InitData();
        }

        public HomeViewModel HomeViewModel { get; set; }
        public ColocAnnounceViewModel ColocAnnounceViewModel { get; set; }
        public SearchColocViewModel SearchColocViewModel { get; set; }
        public PeopleSearchingViewModel PeopleSearchingViewModel {get;set;}

        public void InitData()
        {
            HomeViewModel = new HomeViewModel();
            ColocAnnounceViewModel = new ColocAnnounceViewModel();
            SearchColocViewModel = new SearchColocViewModel();
            PeopleSearchingViewModel = new PeopleSearchingViewModel();
        }
    }
}