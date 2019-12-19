using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class RoleSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public RoleSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private RoleSql()
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

		private List<RoleBo> FillLst(DataTable pdtDataTable)
		{
			List<RoleBo> lstItems = new List<RoleBo>();

			try
			{
				RoleBo roleBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					roleBo = new RoleBo
					{
						IdRole = ABLib.Databases.GetInt32(dr, "IdRole"),
						RoleName = ABLib.Databases.GetString(dr, "RoleName"),
						Description = ABLib.Databases.GetString(dr, "Description")
					};

					lstItems.Add(roleBo);
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
