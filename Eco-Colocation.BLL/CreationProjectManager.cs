using Eco_Colocation.DAL;
namespace Eco_Colocation.BLL
{
	public class CreationProjectManager
	{
		#region Properties

		private CreationProjectAdSql CreationProjectAdSql { get; set; }

		#endregion

		#region Initialization

		public CreationProjectManager(CreationProjectAdSql poCreationProjectAdSql)
			: this()
		{
			this.CreationProjectAdSql = poCreationProjectAdSql;
		}

		private CreationProjectManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.CreationProjectAdSql = null;
		}

		#endregion
	}
}
