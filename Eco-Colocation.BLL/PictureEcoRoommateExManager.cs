using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class PictureEcoRoommateExManager
	{
		#region Properties

 //  'PictureEcoRoommateExSql' 
		private PictureEcoRoommateExSql PictureEcoRoommateExSql { get; set; }
 //  'PictureEcoRoommateExSql' 

		#endregion

		#region Initialization

 //  'PictureEcoRoommateExSql' 
		public PictureEcoRoommateExManager(PictureEcoRoommateExSql poPictureEcoRoommateExSql)
 //  'PictureEcoRoommateExSql' 
			: this()
		{
			this.PictureEcoRoommateExSql = poPictureEcoRoommateExSql;
		}

		private PictureEcoRoommateExManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.PictureEcoRoommateExSql = null;
		}

		#endregion
	}
}
