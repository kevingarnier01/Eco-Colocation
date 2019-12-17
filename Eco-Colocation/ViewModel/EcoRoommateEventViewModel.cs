namespace Eco_Colocation.ViewModel
{
	public class EcoRoommateEventViewModel
	{
		public int Id { get; set; }

		public EcoRoommateEventViewModel() { }
		public EcoRoommateEventViewModel(bool init)
		{
			if (init == true)
			{
				Id = 0;
			}
		}
	}
}