using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class UserManager
	{
		#region Properties

		private UserSql UserSql { get; set; }

		#endregion

		#region Initialization

		public UserManager(UserSql poUserSql)
			: this()
		{
			this.UserSql = poUserSql;
		}

		private UserManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.UserSql = null;
		}

		#endregion
	}
}
