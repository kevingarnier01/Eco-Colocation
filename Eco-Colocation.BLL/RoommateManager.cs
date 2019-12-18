using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class RoommateManager
	{
		#region Properties
		
		private RoommateSql RoommateSql { get; set; } 

		#endregion

		#region Initialization
		 
		public RoommateManager(RoommateSql poRoommateSql)
			: this()
		{
			this.RoommateSql = poRoommateSql;
		}

		private RoommateManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.RoommateSql = null;
		}

		#endregion
	}
}
