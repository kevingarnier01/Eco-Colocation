using System.Collections.Generic;

namespace Eco_Colocation.BO
{
	public class RoleBo
	{
		public RoleBo()
		{

			this.UserBo = new HashSet<UserBo>();

		}

		public int IdRole { get; set; }

		public string RoleName { get; set; }

		public string Description { get; set; }



		public virtual ICollection<UserBo> UserBo { get; set; }
	}
}