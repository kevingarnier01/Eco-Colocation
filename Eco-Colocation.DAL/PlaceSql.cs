using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class PlaceSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public PlaceSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private PlaceSql()
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

		private List<PlaceBo> FillLst(DataTable pdtDataTable)
		{
			List<PlaceBo> lstItems = new List<PlaceBo>();

			try
			{
				PlaceBo placeBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					placeBo = new PlaceBo
					{
						IdPlace = ABLib.Databases.GetInt32(dr, "IdPlace"),
						City = ABLib.Databases.GetString(dr, "City"),
						PostalCode = ABLib.Databases.GetString(dr, "PostalCode"),
						Department = ABLib.Databases.GetString(dr, "Department"),
						DepartmentNumber = ABLib.Databases.GetString(dr, "DepartmentNumber"),
						Region = ABLib.Databases.GetString(dr, "Region"),
						County = ABLib.Databases.GetString(dr, "County"),
						ScopeResearch = ABLib.Databases.GetByte(dr, "ScopeResearch")
					};

					lstItems.Add(placeBo);
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
