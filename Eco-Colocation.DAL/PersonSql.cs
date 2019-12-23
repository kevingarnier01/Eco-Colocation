using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

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
						Email = ABLib.Databases.GetString(dr, "Email"),
						FirstName = ABLib.Databases.GetString(dr, "FirstName"),
						LastName = ABLib.Databases.GetString(dr, "LastName"),
						Civility = ABLib.Databases.GetByte(dr, "Civility"),
						Country = ABLib.Databases.GetString(dr, "Country"),
						DateBirth = ABLib.Databases.GetString(dr, "DateBirth"),
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
