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

        public PersonneModel PersonneModel { get; set; }
		public List<PeopleSearchingViewModel> LstPeopleSearchingVM { get; set; }
		public int IdPeopleSearching { get; set; }

        public void InitData()
        {
            PersonneModel = new PersonneModel();
			LstPeopleSearchingVM = new List<PeopleSearchingViewModel>();
        }
    }
}