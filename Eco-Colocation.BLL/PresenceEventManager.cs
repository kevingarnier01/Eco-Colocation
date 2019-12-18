namespace Eco_Colocation.BLL
{
	public class PresenceEventManager
	{
		#region Properties

 //  'PresenceEventSql' 
		private PresenceEventSql PresenceEventSql { get; set; }
 //  'PresenceEventSql' 

		#endregion

		#region Initialization

 //  'PresenceEventSql' 
		public PresenceEventManager(PresenceEventSql poPresenceEventSql)
 //  'PresenceEventSql' 
			: this()
		{
			this.PresenceEventSql = poPresenceEventSql;
		}

		private PresenceEventManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.PresenceEventSql = null;
		}

		#endregion
	}
}
