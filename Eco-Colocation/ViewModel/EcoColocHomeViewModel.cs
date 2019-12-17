namespace Eco_Colocation.ViewModel
{
    public class EcoRoommateHomeViewModel
    {
        public string TypeRecherche { get; set; }
		public string InformationPlaceSearching { get; set; }
		
		public EcoRoommateHomeViewModel() { }
		public EcoRoommateHomeViewModel(bool init)
		{
			if (init == true)
			{
				TypeRecherche = string.Empty;
				InformationPlaceSearching = string.Empty;
			}
		}
	}
}