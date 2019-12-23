namespace Eco_Colocation.BO
{
	public class UserBo
	{
		public UserBo(){}
		public UserBo(bool init)
		{
			if (init)
			{
				this.Activated = true;

				this.MembershipBo = new MembershipBo(true);

				PersonBo = new PersonBo(true);

				AgencyBo = new AgencyBo(true);

				TypeUser = 2;
			}
		}

		public int IdUser { get; set; }

		public string UserName { get; set; }

		public byte TypeUser { get; set; }

		public bool Activated { get; set; }


		public virtual PersonBo PersonBo { get; set; }

		public virtual AgencyBo AgencyBo { get; set; }

		public virtual MembershipBo MembershipBo { get; set; }
	}
}