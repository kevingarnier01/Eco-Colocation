using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class EcoRoommateExistingSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public EcoRoommateExistingSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private EcoRoommateExistingSql()
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

		private List<EcoRoommateExistingBo> FillLst(DataTable pdtDataTable)
		{
			List<EcoRoommateExistingBo> lstItems = new List<EcoRoommateExistingBo>();

			try
			{
				EcoRoommateExistingBo ecoRoommateExistingBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					ecoRoommateExistingBo = new EcoRoommateExistingBo
					{
						IdEcoRoommateExisting = ABLib.Databases.GetInt32(dr, "IdEcoRoommateExisting"),
						IdUser = ABLib.Databases.GetInt32(dr, "IdUser"),
						EcoRoommateName = ABLib.Databases.GetString(dr, "EcoRoommateName"),
						RommateNumber = ABLib.Databases.GetInt16(dr, "RommateNumber"),
						Country = ABLib.Databases.GetString(dr, "Country"),
						Region = ABLib.Databases.GetString(dr, "Region"),
						Department = ABLib.Databases.GetString(dr, "Department"),
						DepartmentNumber = ABLib.Databases.GetString(dr, "DepartmentNumber"),
						City = ABLib.Databases.GetString(dr, "City"),
						PostalCode = ABLib.Databases.GetString(dr, "PostalCode"),
						Email = ABLib.Databases.GetString(dr, "Email"),
						Description = ABLib.Databases.GetString(dr, "Description"),
						EcoImplication = ABLib.Databases.GetByte(dr, "EcoImplication"),
						TableEco = ABLib.Databases.GetString(dr, "TableEco"),
						TableHousing = ABLib.Databases.GetString(dr, "TableHousing"),
					};

					lstItems.Add(ecoRoommateExistingBo);
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
