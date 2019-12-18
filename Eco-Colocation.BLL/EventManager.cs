using Eco_Colocation.DAL;
namespace Eco_Colocation.BLL
{
	public class EventManager
	{
		#region Properties

 //  'EventSql' 
		private EventSql EventSql { get; set; }
 //  'EventSql' 

		#endregion

		#region Initialization

 //  'EventSql' 
		public EventManager(EventSql poEventSql)
 //  'EventSql' 
			: this()
		{
			this.EventSql = poEventSql;
		}

		private EventManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.EventSql = null;
		}

		#endregion
	}
}
