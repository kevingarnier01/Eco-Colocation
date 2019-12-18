using Eco_Colocation.DAL;
namespace Eco_Colocation.BLL
{
	public class EcoRoommateExistingManager
	{
		#region Properties

 //  'EcoRoommateExistingSql' 
		private EcoRoommateExistingSql EcoRoommateExistingSql { get; set; }
 //  'EcoRoommateExistingSql' 

		#endregion

		#region Initialization

 //  'EcoRoommateExistingSql' 
		public EcoRoommateExistingManager(EcoRoommateExistingSql poEcoRoommateExistingSql)
 //  'EcoRoommateExistingSql' 
			: this()
		{
			this.EcoRoommateExistingSql = poEcoRoommateExistingSql;
		}

		private EcoRoommateExistingManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.EcoRoommateExistingSql = null;
		}

		#endregion
	}
}
