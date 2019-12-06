namespace Eco_Colocation.ViewModel
{
    public class EcoRoommateHomeModel
    {
        public EcoRoommateHomeModel()
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