using Eco_Colocation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Colocation.BLL
{
	public class RoleManager
	{
		#region Properties

 //  'RoleSql' 
		private RoleSql RoleSql { get; set; }
 //  'RoleSql' 

		#endregion

		#region Initialization

 //  'RoleSql' 
		public RoleManager(RoleSql poRoleSql)
 //  'RoleSql' 
			: this()
		{
			this.RoleSql = poRoleSql;
		}

		private RoleManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.RoleSql = null;
		}

		#endregion
	}
}
