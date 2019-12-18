using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class PictureDevConversationManager
	{
		#region Properties

 //  'AssocietedEventSql' 
		private AssocietedEventSql AssocietedEventSql { get; set; }
 //  'AssocietedEventSql' 

		#endregion

		#region Initialization

 //  'AssocietedEventSql' 
		public PictureDevConversationManager(AssocietedEventSql poAssocietedEventSql)
 //  'AssocietedEventSql' 
			: this()
		{
			this.AssocietedEventSql = poAssocietedEventSql;
		}

		private PictureDevConversationManager()
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
