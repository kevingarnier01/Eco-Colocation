using Eco_Colocation.DAL;
using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class AgencyManager
	{
		#region Properties

 //  'AgencySql' 
		private AgencySql AgencySql { get; set; }
 //  'AgencySql' 

		#endregion

		#region Initialization

 //  'AgencySql' 
		public AgencyManager(AgencySql poAgencySql)
 //  'AgencySql' 
			: this()
		{
			this.AgencySql = poAgencySql;
		}

		private AgencyManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.AgencySql = null;
		}

		#endregion
	}
}
