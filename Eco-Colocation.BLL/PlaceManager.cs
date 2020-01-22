using System;
using System.Collections.Generic;
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

		public bool Upd(PlaceBo placeBo, int idResearchRoommate, int idCreationProject)
		{
			if (this.PlaceSql == null)
				return false;
			else
			{
				return this.PlaceSql.Upd(placeBo, idResearchRoommate, idCreationProject);
			}
		}

		public List<PlaceBo> GetByResearchRoommateId(int idResearchRoommate)
		{
			if (this.PlaceSql == null)
				return null;
			else
			{
				return this.PlaceSql.GetByResearchRoommateId(idResearchRoommate);
			}
		}

		#endregion


		#region Initialization

		public PlaceManager(PlaceSql poPlaceSql)
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
