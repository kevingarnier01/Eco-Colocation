﻿using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class PlaceSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public PlaceSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private PlaceSql()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.SqlDbStoredProcedureDAL = null;
		}

		#endregion

		#region Methods

		public int Add(PlaceBo placeBo, int idResearchRoommate, int idCreationProject)
		{
			ABLib.DAL.Sql.SqlParametersCollection oSqlParameters = new ABLib.DAL.Sql.SqlParametersCollection();
			oSqlParameters.AddIdOut("IdPlace");
			oSqlParameters.Add("IdResearchRoommate", (idResearchRoommate == 0) ? null : idResearchRoommate.ToString(), SqlDbType.NVarChar);
			oSqlParameters.Add("IdCreationProject", (idCreationProject == 0) ? null : idCreationProject.ToString(), SqlDbType.NVarChar);
			oSqlParameters.Add("City", placeBo.City, SqlDbType.NVarChar);
			oSqlParameters.Add("PostalCode", placeBo.PostalCode, SqlDbType.NVarChar);
			oSqlParameters.Add("Department", placeBo.Department, SqlDbType.NVarChar);
			oSqlParameters.Add("DepartmentNumber", placeBo.DepartmentNumber, SqlDbType.NVarChar);
			oSqlParameters.Add("Region", placeBo.Region, SqlDbType.NVarChar);
			oSqlParameters.Add("Country", placeBo.Country, SqlDbType.NVarChar);
			oSqlParameters.Add("ScopeResearch", placeBo.ScopeResearch, SqlDbType.TinyInt);
			this.SqlDbStoredProcedureDAL.Add(placeBo, "IdPlace", 0, "Place_Add", oSqlParameters);

			return placeBo.IdPlace;
		}

		public bool Upd(PlaceBo placeBo, int idResearchRoommate, int idCreationProject)
		{
			ABLib.DAL.Sql.SqlParametersCollection oSqlParameters = new ABLib.DAL.Sql.SqlParametersCollection();
			oSqlParameters.Add("IdResearchRoommate", (idResearchRoommate == 0) ? null : idResearchRoommate.ToString(), SqlDbType.NVarChar);
			oSqlParameters.Add("IdCreationProject", (idCreationProject == 0) ? null : idCreationProject.ToString(), SqlDbType.NVarChar);
			oSqlParameters.Add("City", placeBo.City, SqlDbType.NVarChar);
			oSqlParameters.Add("PostalCode", placeBo.PostalCode, SqlDbType.NVarChar);
			oSqlParameters.Add("Department", placeBo.Department, SqlDbType.NVarChar);
			oSqlParameters.Add("DepartmentNumber", placeBo.DepartmentNumber, SqlDbType.NVarChar);
			oSqlParameters.Add("Region", placeBo.Region, SqlDbType.NVarChar);
			oSqlParameters.Add("Country", placeBo.Country, SqlDbType.NVarChar);
			oSqlParameters.Add("ScopeResearch", placeBo.ScopeResearch, SqlDbType.TinyInt);

			return this.SqlDbStoredProcedureDAL.ExecWithTryCatch("Place_Upd", oSqlParameters);
		}

		public List<PlaceBo> GetByResearchRoommateId(int idResearchRoommate)
		{
			ABLib.DAL.Sql.SqlParametersCollection oSqlParameters = new ABLib.DAL.Sql.SqlParametersCollection();
			oSqlParameters.Add("IdResearchRoommate", idResearchRoommate, SqlDbType.Int);

			List<PlaceBo> lstPlaceBo = this.FillLst(this.SqlDbStoredProcedureDAL.ExecWithResultDt("Place_GetLstByResearchRoommateId", oSqlParameters));

			return lstPlaceBo;
		}

		#endregion

		#region Fill

		private List<PlaceBo> FillLst(DataTable pdtDataTable)
		{
			List<PlaceBo> lstItems = new List<PlaceBo>();

			try
			{
				PlaceBo placeBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					placeBo = new PlaceBo
					{
						IdPlace = ABLib.Databases.GetInt32(dr, "IdPlace"),
						IdResearchRoommate = ABLib.Databases.GetInt32(dr, "IdResearchRoommate"),
						IdCreationProject = ABLib.Databases.GetInt32(dr, "IdCreationProject"),
						City = ABLib.Databases.GetString(dr, "City"),
						PostalCode = ABLib.Databases.GetString(dr, "PostalCode"),
						Department = ABLib.Databases.GetString(dr, "Department"),
						DepartmentNumber = ABLib.Databases.GetString(dr, "DepartmentNumber"),
						Region = ABLib.Databases.GetString(dr, "Region"),
						Country = ABLib.Databases.GetString(dr, "County"),
						ScopeResearch = ABLib.Databases.GetByte(dr, "ScopeResearch")
					};

					lstItems.Add(placeBo);
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
