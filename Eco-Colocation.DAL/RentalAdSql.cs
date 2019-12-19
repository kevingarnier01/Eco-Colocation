using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class RentalAdSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public RentalAdSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private RentalAdSql()
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

		private List<RentalAdBo> FillLst(DataTable pdtDataTable)
		{
			List<RentalAdBo> lstItems = new List<RentalAdBo>();

			try
			{
				RentalAdBo rentalAdBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					rentalAdBo = new RentalAdBo
					{
						IdRentalAd = ABLib.Databases.GetInt32(dr, "IdRentalAd"),
						IdUser = ABLib.Databases.GetInt32(dr, "IdUser"),
						Introduction = ABLib.Databases.GetString(dr, "Introduction"),
						Description = ABLib.Databases.GetString(dr, "Description"),
						Street = ABLib.Databases.GetString(dr, "Street"),
						City = ABLib.Databases.GetString(dr, "City"),
						PostalCode = ABLib.Databases.GetString(dr, "PostalCode"),
						Department = ABLib.Databases.GetString(dr, "Department"),
						DepartmentNumber = ABLib.Databases.GetString(dr, "DepartmentNumber"),
						Region = ABLib.Databases.GetString(dr, "Region"),
						Country = ABLib.Databases.GetString(dr, "Country"),
						Latitude = ABLib.Databases.GetDecimal(dr, "Latitude"),
						Longitude = ABLib.Databases.GetDecimal(dr, "Longitude"),
						HousingType = ABLib.Databases.GetByte(dr, "HousingType"),
						HousingImplantation = ABLib.Databases.GetByte(dr, "HousingImplantation"),
						HousingSurface = ABLib.Databases.GetByte(dr, "HousingSurface"),
						LandSurface = ABLib.Databases.GetInt32(dr, "LandSurface"),
						HousingPieceNumber = ABLib.Databases.GetInt16(dr, "HousingPieceNumber"),
						RoommateNumberStaying = ABLib.Databases.GetInt16(dr, "RoommateNumberStaying"),
						RoommateNumberResearched = ABLib.Databases.GetInt16(dr, "RoommateNumberResearched"),
						AccessHandicapped = ABLib.Databases.GetBoolean(dr, "AccessHandicapped"),
						AccesPublicTransport = ABLib.Databases.GetBoolean(dr, "AccesPublicTransport"),
						AccesInfoSup = ABLib.Databases.GetString(dr, "AccesInfoSup"),
						TolerationAlcoholConsommation = ABLib.Databases.GetBoolean(dr, "TolerationAlcoholConsommation"),
						TolerationSmoker = ABLib.Databases.GetBoolean(dr, "TolerationSmoker"),
						TolerationPets = ABLib.Databases.GetBoolean(dr, "TolerationPets"),
						TolerationInfoSup = ABLib.Databases.GetString(dr, "TolerationInfoSup"),
						DatePublish = ABLib.Databases.GetDateTime(dr, "DatePublish"),
						ActivatedAnnouncement = ABLib.Databases.GetBoolean(dr, "ActivatedAnnouncement")
					};

					lstItems.Add(rentalAdBo);
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
