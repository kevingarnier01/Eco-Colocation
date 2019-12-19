using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class PictureDevConversationSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public PictureDevConversationSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private PictureDevConversationSql()
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

		private List<PictureDevConversationBo> FillLst(DataTable pdtDataTable)
		{
			List<PictureDevConversationBo> lstItems = new List<PictureDevConversationBo>();

			try
			{
				PictureDevConversationBo pictureDevConversationBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					pictureDevConversationBo = new PictureDevConversationBo
					{
						IdPictureDevConversation = ABLib.Databases.GetInt32(dr, "IdPictureDevConversation"),
						IdDevConversation = ABLib.Databases.GetInt32(dr, "IdDevConversation"),
						PictureName = ABLib.Databases.GetString(dr, "PictureName")
					};

					lstItems.Add(pictureDevConversationBo);
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
