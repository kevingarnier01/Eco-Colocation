using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class PictureCreationProjectSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public PictureCreationProjectSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private PictureCreationProjectSql()
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

		private List<PictureCreationProjectBo> FillLst(DataTable pdtDataTable)
		{
			List<PictureCreationProjectBo> lstItems = new List<PictureCreationProjectBo>();

			try
			{
				PictureCreationProjectBo pictureCreationProjectBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					pictureCreationProjectBo = new PictureCreationProjectBo
					{
						IdPictureCreationProject = ABLib.Databases.GetInt32(dr, "IdPictureCreationProject"),
						IdProjetCreation = ABLib.Databases.GetInt32(dr, "IdProjetCreation"),
						PictureName = ABLib.Databases.GetString(dr, "PictureName"),
						OrderNumber = ABLib.Databases.GetByte(dr, "OrderNumber")
					};

					lstItems.Add(pictureCreationProjectBo);
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
