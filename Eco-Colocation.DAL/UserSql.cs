using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class UserSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public UserSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private UserSql()
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

		private List<UserBo> FillLst(DataTable pdtDataTable)
		{
			List<UserBo> lstItems = new List<UserBo>();

			try
			{
				UserBo userBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					userBo = new UserBo
					{
						IdUser = ABLib.Databases.GetInt32(dr, "IdUser"),
						UserName = ABLib.Databases.GetString(dr, "UserName"),
						TypeUser = ABLib.Databases.GetByte(dr, "TypeUser"),
						Activated = ABLib.Databases.GetBoolean(dr, "Activated")
					};

					lstItems.Add(userBo);
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
