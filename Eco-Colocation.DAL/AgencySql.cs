using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class AgencySql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public AgencySql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private AgencySql()
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

		private List<AgencyBo> FillLst(DataTable pdtDataTable)
		{
			List<AgencyBo> lstItems = new List<AgencyBo>();

			try
			{
				AgencyBo agencyBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					agencyBo = new AgencyBo
					{
						IdAgency = ABLib.Databases.GetInt32(dr, "IdAgency"),
						Name = ABLib.Databases.GetString(dr, "Name"),
						Email = ABLib.Databases.GetString(dr, "Email"),
						Phone = ABLib.Databases.GetString(dr, "Phone"),
						StreetNumber = ABLib.Databases.GetString(dr, "StreetNumber"),
						Street = ABLib.Databases.GetString(dr, "Street"),
						City = ABLib.Databases.GetString(dr, "City"),
						PostalCode = ABLib.Databases.GetString(dr, "PostalCode"),
						Department = ABLib.Databases.GetString(dr, "Department"),
						DepartmentNumber = ABLib.Databases.GetString(dr, "DepartmentNumber"),
						Region = ABLib.Databases.GetString(dr, "Region"),
						County = ABLib.Databases.GetString(dr, "County")
					};

					lstItems.Add(agencyBo);
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