using Eco_Colocation.BO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Eco_Colocation.DAL
{
	public class MembershipSql
	{
		#region Properties

		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public MembershipSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private MembershipSql()
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

		private List<MembershipBo> FillLst(DataTable pdtDataTable)
		{
			List<MembershipBo> lstItems = new List<MembershipBo>();

			try
			{
				MembershipBo membershipBo = null;

				foreach (DataRow dr in pdtDataTable.Rows)
				{
					membershipBo = new MembershipBo
					{
						UserId = ABLib.Databases.GetInt32(dr, "UserId"),
						CreateDate = ABLib.Databases.GetDateTime(dr, "CreateDate"),
						ConfirmationToken = ABLib.Databases.GetString(dr, "ConfirmationToken"),
						IsConfirmed = ABLib.Databases.GetBoolean(dr, "IsConfirmed"),
						LastPasswordFailureDate = ABLib.Databases.GetDateTime(dr, "LastPasswordFailureDate"),
						PasswordFailuresSinceLastSuccess = ABLib.Databases.GetInt32(dr, "PasswordFailuresSinceLastSuccess"),
						Password = ABLib.Databases.GetString(dr, "Password"),
						PasswordChangedDate = ABLib.Databases.GetDateTime(dr, "PasswordChangedDate"),
						PasswordSalt = ABLib.Databases.GetString(dr, "PasswordSalt"),
						PasswordVerificationToken = ABLib.Databases.GetString(dr, "PasswordVerificationToken"),
						PasswordVerificationTokenExpirationDate = ABLib.Databases.GetDateTime(dr, "PasswordVerificationTokenExpirationDate")
					};

					lstItems.Add(membershipBo);
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
