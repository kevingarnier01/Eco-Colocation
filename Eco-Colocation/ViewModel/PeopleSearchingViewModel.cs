using Eco_Colocation.Models;

namespace Eco_Colocation.ViewModel
{
    public class PeopleSearchingViewModel
    {
        public PeopleSearchingViewModel()
        {
            InitData();
        }

        public PersonneModel PersonneModel { get; set; }

        public void InitData()
        {
            PersonneModel = new PersonneModel();
        }
    }
}