using Eco_Colocation.DAL;
using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class DevConversationManager
	{
		#region Properties


		private DevConversationSql DevConversationSql { get; set; }


		#endregion

		#region Initialization


		public DevConversationManager(DevConversationSql poDevConversationSql)

			: this()
		{
			this.DevConversationSql = poDevConversationSql;
		}

		private DevConversationManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.DevConversationSql = null;
		}

		#endregion
	}
}
