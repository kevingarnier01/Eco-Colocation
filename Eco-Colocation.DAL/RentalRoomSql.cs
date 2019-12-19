using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Colocation.DAL
{
	public class RentalRoomSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public RentalRoomSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private RentalRoomSql()
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

		private List<RentalRoomBo> FillLst(DataTable pdtDataTable)
		{
			List<RentalRoomBo> lstItems = new List<RentalRoomBo>();

			try
			{
				RentalRoomBo rentalRoomBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					rentalRoomBo = new RentalRoomBo
					{
						IdRentalRoom = ABLib.Databases.GetInt32(dr, "IdRentalRoom"),
						IdRentalAd = ABLib.Databases.GetInt32(dr, "IdRentalAd"),
						RentPrice = ABLib.Databases.GetDecimal(dr, "RentPrice"),
						Charges = ABLib.Databases.GetDecimal(dr, "Charges"),
						ChargesDetail = ABLib.Databases.GetString(dr, "ChargesDetail"),
						Caution = ABLib.Databases.GetDecimal(dr, "Caution"),
						Surface = ABLib.Databases.GetInt16(dr, "Surface"),
						Furnished = ABLib.Databases.GetBoolean(dr, "Furnished"),
						AvalaibleDate = ABLib.Databases.GetDateTime(dr, "AvalaibleDate"),
						AvalaibleEndDate = ABLib.Databases.GetDateTime(dr, "AvalaibleEndDate")
					};

					lstItems.Add(rentalRoomBo);
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
