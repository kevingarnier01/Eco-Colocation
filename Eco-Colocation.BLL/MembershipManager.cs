using Eco_Colocation.DAL;
namespace Eco_Colocation.BLL
{
	public class MembershipManager
	{
		#region Properties

 //  'MembershipSql' 
		private MembershipSql MembershipSql { get; set; }
 //  'MembershipSql' 

		#endregion

		#region Initialization

 //  'MembershipSql' 
		public MembershipManager(MembershipSql poMembershipSql)
 //  'MembershipSql' 
			: this()
		{
			this.MembershipSql = poMembershipSql;
		}

		private MembershipManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.MembershipSql = null;
		}

		#endregion
	}
}
