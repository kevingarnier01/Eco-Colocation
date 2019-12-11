using System.Collections.Generic;

namespace Eco_Colocation.BO
{
	public class RoleBo
	{
		public RoleBo()
		{

			this.AccountBo = new HashSet<AccountBo>();

		}

		public int IdRole { get; set; }

		public string RoleName { get; set; }

		public string Description { get; set; }



		public virtual ICollection<AccountBo> AccountBo { get; set; }
	}
}