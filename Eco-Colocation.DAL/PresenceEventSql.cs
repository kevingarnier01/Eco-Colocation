using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class PresenceEventSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public PresenceEventSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private PresenceEventSql()
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

		private List<PresenceEventBo> FillLst(DataTable pdtDataTable)
		{
			List<PresenceEventBo> lstItems = new List<PresenceEventBo>();

			try
			{
				PresenceEventBo presenceEventBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					presenceEventBo = new PresenceEventBo
					{
						IdUser = ABLib.Databases.GetInt32(dr, "IdUser"),
						IdEvent = ABLib.Databases.GetInt32(dr, "IdEvent"),
						Status = ABLib.Databases.GetByte(dr, "Status")
					};

					lstItems.Add(presenceEventBo);
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
