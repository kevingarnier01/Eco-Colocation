using System.Collections.Generic;

namespace Eco_Colocation.BO
{
	public class UserBo
	{
		public UserBo()
		{

			this.Activated = true;

			this.RentalAdBo = new HashSet<RentalAdBo>();

		}

		public int IdUser { get; set; }

		public string Email { get; set; }

		public bool Activated { get; set; }


		public virtual ICollection<RentalAdBo> RentalAdBo { get; set; }

		public virtual PersonBo PersonBo { get; set; }
				
		public virtual webpages_MembershipBo webpages_MembershipBo { get; set; }
	}
}