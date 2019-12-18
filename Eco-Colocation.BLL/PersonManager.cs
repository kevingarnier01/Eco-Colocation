using Eco_Colocation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Colocation.BLL
{
	public class PersonManager
	{
		#region Properties

 //  'PersonSql' 
		private PersonSql PersonSql { get; set; }
 //  'PersonSql' 

		#endregion

		#region Initialization

 //  'PersonSql' 
		public PersonManager(PersonSql poPersonSql)
 //  'PersonSql' 
			: this()
		{
			this.PersonSql = poPersonSql;
		}

		private PersonManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.PersonSql = null;
		}

		#endregion
	}
}
