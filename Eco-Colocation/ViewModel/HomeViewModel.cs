namespace Eco_Colocation.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            InitData();
        }

        public string TypeRecherche { get; set; }

		public string InformationPlaceSearching { get; set; }


		public void InitData()
        {
            TypeRecherche = string.Empty;
			InformationPlaceSearching = string.Empty;
        }
    }
}