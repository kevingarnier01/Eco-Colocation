using Eco_Colocation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Colocation.BLL
{
	public class PlaceManager
	{
		#region Properties

 //  'PlaceSql' 
		private PlaceSql PlaceSql { get; set; }
 //  'PlaceSql' 

		#endregion

		#region Initialization

 //  'PlaceSql' 
		public PlaceManager(PlaceSql poPlaceSql)
 //  'PlaceSql' 
			: this()
		{
			this.PlaceSql = poPlaceSql;
		}

		private PlaceManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.PlaceSql = null;
		}

		#endregion
	}
}
