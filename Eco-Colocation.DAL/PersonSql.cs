using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Eco_Colocation.DAL
{
	public class PersonSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public PersonSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private PersonSql()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.SqlDbStoredProcedureDAL = null;
		}

		#endregion

		#region Methods

		public int Add(PersonBo personBo, int idUser)
		{
			ABLib.DAL.Sql.SqlParametersCollection oSqlParameters = new ABLib.DAL.Sql.SqlParametersCollection();
			oSqlParameters.AddIdOut("IdPerson");
			oSqlParameters.Add("IdUser", idUser, SqlDbType.Int);
			oSqlParameters.Add("FirstName", personBo.FirstName, SqlDbType.NVarChar);
			oSqlParameters.Add("LastName", personBo.LastName, SqlDbType.NVarChar);
			oSqlParameters.Add("Civility", personBo.Civility, SqlDbType.TinyInt);
			oSqlParameters.Add("Country", personBo.Country, SqlDbType.NVarChar);
			oSqlParameters.Add("DateBorn", personBo.DateBorn, SqlDbType.Date);
			oSqlParameters.Add("Activity", personBo.Activity, SqlDbType.TinyInt);
			oSqlParameters.Add("PhoneCode", personBo.PhoneCode, SqlDbType.NVarChar);
			oSqlParameters.Add("PhoneNumber", personBo.PhoneNumber, SqlDbType.NVarChar);
			oSqlParameters.Add("ContactType", personBo.ContactType, SqlDbType.TinyInt);
			oSqlParameters.Add("PersonnalityDescription", personBo.PersonnalityDescription, SqlDbType.NVarChar);
			oSqlParameters.Add("DateInscription", DateTime.Now, SqlDbType.DateTime);
			oSqlParameters.Add("DateLastActivity", DateTime.Now, SqlDbType.DateTime);

			this.SqlDbStoredProcedureDAL.Add(personBo, "IdPerson", 0, "Person_Add", oSqlParameters);

			return personBo.IdPerson;
		}

		public PersonBo GetByUserId(int idUser)
		{
			ABLib.DAL.Sql.SqlParametersCollection oSqlParameters = new ABLib.DAL.Sql.SqlParametersCollection();
			oSqlParameters.Add("IdUser", idUser, SqlDbType.Int);
			
			PersonBo personBo = this.FillLst(this.SqlDbStoredProcedureDAL.ExecWithResultDt("Person_GetByUderId", oSqlParameters)).FirstOrDefault();

			return personBo;
		}

		#endregion

		#region Fill

		private List<PersonBo> FillLst(DataTable pdtDataTable)
		{
			List<PersonBo> lstItems = new List<PersonBo>();

			try
			{
				PersonBo personBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					personBo = new PersonBo
					{
						IdPerson = ABLib.Databases.GetInt32(dr, "IdPerson"),
						FirstName = ABLib.Databases.GetString(dr, "FirstName"),
						LastName = ABLib.Databases.GetString(dr, "LastName"),
						Civility = ABLib.Databases.GetByte(dr, "Civility"),
						Country = ABLib.Databases.GetString(dr, "Country"),
						DateBorn = ABLib.Databases.GetDateTime(dr, "DateBorn"),
						Activity = ABLib.Databases.GetByte(dr, "Activity"),
						PhoneCode = ABLib.Databases.GetString(dr, "PhoneCode"),
						PhoneNumber = ABLib.Databases.GetString(dr, "PhoneNumber"),
						ContactType = ABLib.Databases.GetByte(dr, "ContactType"),
						PersonnalityDescription = ABLib.Databases.GetString(dr, "PersonnalityDescription"),
						DateInscription = ABLib.Databases.GetDateTime(dr, "DateInscription"),
						DateLastActivity = ABLib.Databases.GetDateTime(dr, "DateLastActivity")
					};

					lstItems.Add(personBo);
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
