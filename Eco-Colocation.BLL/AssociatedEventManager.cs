using Eco_Colocation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Colocation.BLL
{
	public class AssociatedEventManager
	{
		#region Properties

 //  'AssocietedEventSql' 
		private AssocietedEventSql AssocietedEventSql { get; set; }
 //  'AssocietedEventSql' 

		#endregion

		#region Initialization

 //  'AssocietedEventSql' 
#pragma warning disable CS1520 // La méthode doit avoir un type de retour
		public AssocietedEventManager(AssocietedEventSql poAssocietedEventSql)
#pragma warning restore CS1520 // La méthode doit avoir un type de retour
 //  'AssocietedEventSql' 
			: this()
		{
			this.AssocietedEventSql = poAssocietedEventSql;
		}

#pragma warning disable CS1520 // La méthode doit avoir un type de retour
		private AssocietedEventManager()
#pragma warning restore CS1520 // La méthode doit avoir un type de retour
		{
			this.InitData();
		}

		private void InitData()
		{
			this.AssocietedEventSql = null;
		}

		#endregion
	}
}
