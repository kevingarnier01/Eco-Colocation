using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Colocation.DAL
{
	public class UserSql
	{
		#region Properties

		private String SqlConnectionString { get; set; }
		private ABLib.DAL.Sql.SqlDbStoredProcedureDAL SqlDbStoredProcedureDAL { get; set; }

		#endregion

		#region Initialization

		public UserSql(String pstrSqlConnectionString)
			: this()
		{
			this.SqlDbStoredProcedureDAL = new ABLib.DAL.Sql.SqlDbStoredProcedureDAL(pstrSqlConnectionString);
		}

		private UserSql()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.SqlConnectionString = String.Empty;
			this.SqlDbStoredProcedureDAL = null;
		}

		#endregion
	}
}
