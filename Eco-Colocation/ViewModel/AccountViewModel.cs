using Eco_Colocation.App_Start;
using System.Web.Mvc;
namespace Eco_Colocation.ViewModel

{
	public class AccountViewModel
	{
		//UserBo
		public SelectList ActivityLst { get; set; }
		public SelectList CiviliteLst { get; set; }
		public SelectList CountryLst { get; set; }

		//Model
		public BO.UserBo UserBo { get; set; }

		public AccountViewModel() { }
		public AccountViewModel(bool init)
		{
			if (init == true)
			{
				UserBo = new BO.UserBo();
			}
		}

		public void InitLst()
		{
			_Lists _Lists = new _Lists();
			ActivityLst = _Lists.ActivityLst();
			CiviliteLst = _Lists.CivilityLst();
			CountryLst = _Lists.CountryLst();
		}
	}
}