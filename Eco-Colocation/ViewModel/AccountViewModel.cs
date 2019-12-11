using Eco_Colocation.BO;

namespace Eco_Colocation.ViewModel
{
	public class AccountViewModel
	{
		public AccountBo AccountBo { get; set; }

		public AccountViewModel()
		{
			AccountBo = new AccountBo();
		}
	}
}