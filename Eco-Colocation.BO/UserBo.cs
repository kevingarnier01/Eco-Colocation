using System.Collections.Generic;

namespace Eco_Colocation.BO
{
	public class UserBo
	{
		public UserBo()
		{

			this.Activated = true;

			this.RentalAdBo = new HashSet<RentalAdBo>();

			this.MembershipBo = new MembershipBo();

			this.PersonBo = new PersonBo();

		}

		public int IdUser { get; set; }

		public string Email { get; set; }

		public byte TypeUser { get; set; }

		public bool Activated { get; set; }


		public virtual ICollection<RentalAdBo> RentalAdBo { get; set; }

		public virtual PersonBo PersonBo { get; set; }
				
		public virtual MembershipBo MembershipBo { get; set; }
	}
}