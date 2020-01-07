using Eco_Colocation.BO;
using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class PlaceManager
	{
		#region Properties

		private PlaceSql PlaceSql { get; set; }

		#endregion

		#region Methodes

		public int Add(PlaceBo placeBo, int idResearchRoommate, int idCreationProject)
		{
			if (this.PlaceSql == null)
				return 0;
			else
			{
				return this.PlaceSql.Add(placeBo, idResearchRoommate, idCreationProject);
			}
		}

		#endregion


		#region Initialization

		//  'PlaceSql' 
		public PlaceManager(PlaceSql poPlaceSql)
 //  'PlaceSql' 
			: this()
		{
			this.PlaceSql = poPlaceSql;
		}

		private PlaceManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.PlaceSql = null;
		}

		#endregion
	}
}
