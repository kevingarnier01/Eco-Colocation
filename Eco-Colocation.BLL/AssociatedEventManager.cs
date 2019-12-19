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
		private AssociatedEventSql AssocietedEventSql { get; set; }
 //  'AssocietedEventSql' 

		#endregion

		#region Initialization

		public AssociatedEventManager(AssociatedEventSql poAssocietedEventSql)
			: this()
		{
			this.AssocietedEventSql = poAssocietedEventSql;
		}

		private AssociatedEventManager()
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
