using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class CreationProjectAdSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public CreationProjectAdSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private CreationProjectAdSql()
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

		private List<CreationProjectAdBo> FillLst(DataTable pdtDataTable)
		{
			List<CreationProjectAdBo> lstItems = new List<CreationProjectAdBo>();

			try
			{
				CreationProjectAdBo creationProjectAdBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					creationProjectAdBo = new CreationProjectAdBo
					{
						IdCreationProject = ABLib.Databases.GetInt32(dr, "IdCreationProject"),
						IdUser = ABLib.Databases.GetInt32(dr, "IdUser"),
						Introduction = ABLib.Databases.GetString(dr, "Introduction"),
						Description = ABLib.Databases.GetString(dr, "Description"),
						LandEngagement = ABLib.Databases.GetByte(dr, "LandEngagement"),
						LandMaxSurface = ABLib.Databases.GetByte(dr, "LandMaxSurface"),
						LandMaxPrice = ABLib.Databases.GetByte(dr, "LandMaxPrice"),
						HousingEngagement = ABLib.Databases.GetByte(dr, "HousingEngagement"),
						HousingType = ABLib.Databases.GetByte(dr, "HousingType"),
						HousingImplantation = ABLib.Databases.GetByte(dr, "HousingImplantation"),
						HousingMaxSurface = ABLib.Databases.GetByte(dr, "HousingMaxSurface"),
						HousingMaxPrice = ABLib.Databases.GetByte(dr, "HousingMaxPrice"),
						HousingMaxRent = ABLib.Databases.GetByte(dr, "HousingMaxRent"),
						HousingMaxPriceBuilt = ABLib.Databases.GetByte(dr, "HousingMaxPriceBuilt"),
						TotalNumberPerson = ABLib.Databases.GetInt16(dr, "TotalNumberPerson"),
						NbPersonToBuyLand = ABLib.Databases.GetInt16(dr, "NbPersonToBuyLand"),
						NbPersonToBuyHousing = ABLib.Databases.GetInt16(dr, "NbPersonToBuyHousing"),
						NbPersonToRentHousing = ABLib.Databases.GetInt16(dr, "NbPersonToRentHousing"),
						AccesPublicTransport = ABLib.Databases.GetByte(dr, "AccesPublicTransport"),
						AccesInfoSup = ABLib.Databases.GetString(dr, "AccesInfoSup"),
						TolerationAlcoholConsommation = ABLib.Databases.GetBoolean(dr, "TolerationAlcoholConsommation"),
						TolerationSmoker = ABLib.Databases.GetBoolean(dr, "TolerationSmoker"),
						TolerationPets = ABLib.Databases.GetBoolean(dr, "TolerationPets"),
						TolerationInfoSup = ABLib.Databases.GetString(dr, "TolerationInfoSup"),
						ActivatedAnnouncement = ABLib.Databases.GetString(dr, "ActivatedAnnouncement")
					};

					lstItems.Add(creationProjectAdBo);
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
