using Eco_Colocation.Models;
using System.Collections.Generic;

namespace Eco_Colocation.ViewModel
{
    public class PeopleSearchingViewModel
    {
        public PeopleSearchingViewModel()
        {
            InitData();
        }

        public AccountModel PersonneModel { get; set; }
		public List<PeopleSearchingViewModel> LstPeopleSearchingVM { get; set; }
		public int IdPeopleSearching { get; set; }

        public void InitData()
        {
            PersonneModel = new AccountModel();
			LstPeopleSearchingVM = new List<PeopleSearchingViewModel>();
			IdPeopleSearching = new int();

		}
    }
}