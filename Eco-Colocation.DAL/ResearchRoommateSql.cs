using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class ResearchRoommateSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public ResearchRoommateSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private ResearchRoommateSql()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.SqlDbStoredProcedureDAL = null;
		}

		#endregion

		#region Methods
			   
		public int Add(ResearchRoommateBo researchRoommateBo, int idPerson)
		{
			ABLib.DAL.Sql.SqlParametersCollection oSqlParameters = new ABLib.DAL.Sql.SqlParametersCollection();
			oSqlParameters.AddIdOut("IdResearchRoommate");
			oSqlParameters.Add("IdPerson", idPerson, SqlDbType.Int);
			oSqlParameters.Add("MaxBudget", researchRoommateBo.MaxBudget, SqlDbType.SmallInt);
			oSqlParameters.Add("EmailAlert", researchRoommateBo.EmailAlert, SqlDbType.TinyInt);
			oSqlParameters.Add("SearchCriteria", researchRoommateBo.SearchCriteria, SqlDbType.NVarChar);
			oSqlParameters.Add("EcoPractice", researchRoommateBo.EcoPractice, SqlDbType.NVarChar);
			oSqlParameters.Add("PictureName", researchRoommateBo.PictureName, SqlDbType.NVarChar);
			oSqlParameters.Add("ActivatedAnnouncement", 1, SqlDbType.Bit);

			this.SqlDbStoredProcedureDAL.Add(researchRoommateBo, "IdResearchRoommate", 0, "ResearchRoommate_Add", oSqlParameters);

			return researchRoommateBo.IdResearchRoommate;
		}

		#endregion

		#region Fill

		private List<ResearchRoommateBo> FillLst(DataTable pdtDataTable)
		{
			List<ResearchRoommateBo> lstItems = new List<ResearchRoommateBo>();

			try
			{
				ResearchRoommateBo researchRoommateBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					researchRoommateBo = new ResearchRoommateBo
					{
						IdResearchRoommate = ABLib.Databases.GetInt32(dr, "IdResearchRoommate"),
						IdPerson = ABLib.Databases.GetInt32(dr, "IdPerson"),
						MaxBudget = ABLib.Databases.GetInt16(dr, "MaxBudget"),
						EmailAlert = ABLib.Databases.GetByte(dr, "EmailAlert"),
						SearchCriteria = ABLib.Databases.GetString(dr, "SearchCriteria"),
						EcoPractice = ABLib.Databases.GetString(dr, "EcoPractice"),
						PictureName = ABLib.Databases.GetString(dr, "PictureName"),
						ActivatedAnnouncement = ABLib.Databases.GetBoolean(dr, "ActivatedAnnouncement")
					};

					lstItems.Add(researchRoommateBo);
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
