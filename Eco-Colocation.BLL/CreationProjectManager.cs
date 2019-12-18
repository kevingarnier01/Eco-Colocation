using Eco_Colocation.DAL;
namespace Eco_Colocation.BLL
{
	public class CreationProjectManager
	{
		#region Properties

 //  'CreationProjectSql' 
		private CreationProjectSql CreationProjectSql { get; set; }
 //  'CreationProjectSql' 

		#endregion

		#region Initialization

 //  'CreationProjectSql' 
		public CreationProjectManager(CreationProjectSql poCreationProjectSql)
 //  'CreationProjectSql' 
			: this()
		{
			this.CreationProjectSql = poCreationProjectSql;
		}

		private CreationProjectManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.CreationProjectSql = null;
		}

		#endregion
	}
}
