using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class AssociatedEventSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public AssociatedEventSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private AssociatedEventSql()
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

		private List<AssociatedEventBo> FillLst(DataTable pdtDataTable)
		{
			List<AssociatedEventBo> lstItems = new List<AssociatedEventBo>();

			try
			{
				AssociatedEventBo associatedEventBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					associatedEventBo = new AssociatedEventBo
					{
						IdEvent = ABLib.Databases.GetInt32(dr, "IdEvent"),
						IdAssociatedEvent = ABLib.Databases.GetInt32(dr, "IdAssociatedEvent")
					};

					lstItems.Add(associatedEventBo);
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
