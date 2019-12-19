using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class DevConversationSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public DevConversationSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private DevConversationSql()
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

		private List<DevConversationBo> FillLst(DataTable pdtDataTable)
		{
			List<DevConversationBo> lstItems = new List<DevConversationBo>();

			try
			{
				DevConversationBo devConversationBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					devConversationBo = new DevConversationBo
					{
						IdDevConversation = ABLib.Databases.GetInt32(dr, "IdDevConversation"),
						Email = ABLib.Databases.GetString(dr, "Email"),
						Message = ABLib.Databases.GetString(dr, "Message"),
						DateLastSend = ABLib.Databases.GetDateTime(dr, "DateLastSend"),
						Viewed = ABLib.Databases.GetByte(dr, "Viewed")
					};

					lstItems.Add(devConversationBo);
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
