using Eco_Colocation.BO;

namespace Eco_Colocation.ViewModel
{
	public class AccountViewModel
	{
		public UserBo UserBo { get; set; }

		public AccountViewModel()
		{
			UserBo = new UserBo();
		}
	}
}