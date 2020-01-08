using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class RoommateSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public RoommateSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private RoommateSql()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.SqlDbStoredProcedureDAL = null;
		}

		#endregion

		#region Methods

		#endregion

		#region Fill

		private List<RoommateBo> FillLst(DataTable pdtDataTable)
		{
			List<RoommateBo> lstItems = new List<RoommateBo>();

			try
			{
				RoommateBo roommateBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					roommateBo = new RoommateBo
					{
						IdRoommate = ABLib.Databases.GetInt32(dr, "IdRoommate"),
						IdEcoRoommateExisting = ABLib.Databases.GetInt32(dr, "IdEcoRoommateExisting"),
						FirstName = ABLib.Databases.GetString(dr, "FirstName"),
						LastName = ABLib.Databases.GetString(dr, "LastName"),
						Email = ABLib.Databases.GetString(dr, "Email"),
						DateBorn = ABLib.Databases.GetString(dr, "DateBorn"),
						Civility = ABLib.Databases.GetByte(dr, "Civility")
					};

					lstItems.Add(roommateBo);
				}
			}
			catch (Exception)
			{
				throw;
			}

			return lstItems;
		}

		#endregion
	}
}
