using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class ResearchRoommateManager
	{
		#region Properties

		//  'ResearchRoommateSql' 
		private ResearchRoommateSql ResearchRoommateSql { get; set; }
		//  'ResearchRoommateSql' 

		#endregion

		#region Initialization

		//  'ResearchRoommateSql' 
		public ResearchRoommateManager(ResearchRoommateSql poResearchRoommateSql)
			//  'ResearchRoommateSql' 
			: this()
		{
			this.ResearchRoommateSql = poResearchRoommateSql;
		}

		private ResearchRoommateManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.ResearchRoommateSql = null;
		}

		#endregion
	}
}
