using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class PictureEcoRoommateExSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public PictureEcoRoommateExSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private PictureEcoRoommateExSql()
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

		private List<PictureEcoRoommateExBo> FillLst(DataTable pdtDataTable)
		{
			List<PictureEcoRoommateExBo> lstItems = new List<PictureEcoRoommateExBo>();

			try
			{
				PictureEcoRoommateExBo pictureEcoRoommateExBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					pictureEcoRoommateExBo = new PictureEcoRoommateExBo
					{
						IdPictureEcoRoommateEx = ABLib.Databases.GetInt32(dr, "IdPictureEcoRoommateEx"),
						IdEcoRoommateExisting = ABLib.Databases.GetInt32(dr, "IdEcoRoommateExisting"),
						PictureName = ABLib.Databases.GetString(dr, "PictureName"),
						OrderNumber = ABLib.Databases.GetByte(dr, "OrderNumber")
					};

					lstItems.Add(pictureEcoRoommateExBo);
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
