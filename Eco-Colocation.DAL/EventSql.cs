using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class EventSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public EventSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private EventSql()
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

		private List<EventBo> FillLst(DataTable pdtDataTable)
		{
			List<EventBo> lstItems = new List<EventBo>();

			try
			{
				EventBo eventBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					eventBo = new EventBo
					{
						IdEvent = ABLib.Databases.GetInt32(dr, "IdEvent"),
						IdUser = ABLib.Databases.GetInt32(dr, "IdUser"),
						DateStart = ABLib.Databases.GetDateTime(dr, "DateStart"),
						DateEnd = ABLib.Databases.GetDateTime(dr, "DateEnd"),
						StreetNumber = ABLib.Databases.GetString(dr, "StreetNumber"),
						StreetName = ABLib.Databases.GetString(dr, "StreetName"),
						City = ABLib.Databases.GetString(dr, "City"),
						PostalCode = ABLib.Databases.GetString(dr, "PostalCode"),
						Department = ABLib.Databases.GetString(dr, "Department"),
						DepartmentNumber = ABLib.Databases.GetString(dr, "DepartmentNumber"),
						Region = ABLib.Databases.GetString(dr, "Region"),
						Country = ABLib.Databases.GetString(dr, "Country"),
						Link = ABLib.Databases.GetString(dr, "Link"),
						Description = ABLib.Databases.GetString(dr, "Description"),
						PictureName = ABLib.Databases.GetString(dr, "PictureName"),
						DatePublish = ABLib.Databases.GetDateTime(dr, "DatePublish")
					};

					lstItems.Add(eventBo);
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
