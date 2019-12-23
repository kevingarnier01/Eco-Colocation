using Eco_Colocation.App_Start;
using Eco_Colocation.BO;
using System.Web.Mvc;
namespace Eco_Colocation.ViewModel

{
	public class AccountViewModel
	{
		//UserBo
		public SelectList ActivityLst { get; set; }
		public SelectList CiviliteLst { get; set; }
		public SelectList CountryLst { get; set; }
		public SelectList PhoneCodeLst { get; set; }

		//Model
		public UserBo UserBo { get; set; }

		public AccountViewModel() { }
		public AccountViewModel(bool init)
		{
			if (init)
			{
				UserBo = new UserBo(true);
			}
		}

		public void InitLst()
		{
			_Lists _Lists = new _Lists();
			ActivityLst = _Lists.ActivityLst();
			CiviliteLst = _Lists.CivilityLst();
			CountryLst = _Lists.CountryLst();
			PhoneCodeLst = _Lists.PhoneCodeLst();
		}
	}
}