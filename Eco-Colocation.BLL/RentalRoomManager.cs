using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class RentalRoomManager
	{
		#region Properties

 //  'RentalRoomSql' 
		private RentalRoomSql RentalRoomSql { get; set; }
 //  'RentalRoomSql' 

		#endregion

		#region Initialization

 //  'RentalRoomSql' 
		public RentalRoomManager(RentalRoomSql poRentalRoomSql)
 //  'RentalRoomSql' 
			: this()
		{
			this.RentalRoomSql = poRentalRoomSql;
		}

		private RentalRoomManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.RentalRoomSql = null;
		}

		#endregion
	}
}
