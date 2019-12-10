using System.Collections.Generic;

namespace Eco_Colocation.Models
{
	//https://stackoverflow.com/questions/8932193/how-to-add-data-annotation-for-entities-automatically-created-by-data-first

	public class AccountBo
	{
		public AccountBo()
		{
			this.Activated = true;

			this.RentalAdBo = new HashSet<RentalAdBo>();

			this.RoleBo = new HashSet<RoleBo>();
		}


		public int IdAccount { get; set; }

		public System.DateTime CreationDate { get; set; }

		public bool Activated { get; set; }


		public virtual ICollection<RentalAdBo> RentalAdBo { get; set; }

		public virtual UserBo UserBo { get; set; }

		public virtual MembershipBo MembershipBo { get; set; }

		public virtual ICollection<RoleBo> RoleBo { get; set; }
	}
}