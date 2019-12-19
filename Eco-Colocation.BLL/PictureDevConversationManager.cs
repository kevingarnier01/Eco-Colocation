using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class PictureDevConversationManager
	{
		#region Properties

		private AssociatedEventSql AssocietedEventSql { get; set; }

		#endregion

		#region Initialization

		public PictureDevConversationManager(AssociatedEventSql poAssociatedEventSql)
			: this()
		{
			this.AssocietedEventSql = poAssociatedEventSql;
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
