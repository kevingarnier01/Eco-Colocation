using System.Collections.Generic;

namespace Eco_Colocation.ViewModel
{
	public class PeopleSearchingViewModel
    {
		public List<PeopleSearchingViewModel> LstPeopleSearchingVM { get; set; }
		public int IdPeopleSearching { get; set; }

		public PeopleSearchingViewModel()
		{
			LstPeopleSearchingVM = new List<PeopleSearchingViewModel>();
			IdPeopleSearching = new int();
		}
    }
}