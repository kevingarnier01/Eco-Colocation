using Eco_Colocation.BO;
using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class PersonManager
	{
		#region Properties

		private PersonSql PersonSql { get; set; }

		#endregion

		#region Initialization

 //  'PersonSql' 
		public PersonManager(PersonSql poPersonSql)
 //  'PersonSql' 
			: this()
		{
			this.PersonSql = poPersonSql;
		}

		private PersonManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.PersonSql = null;
		}

		#endregion

		#region Methodes

		public int Add(PersonBo personBo, int idUser)
		{
			if (this.PersonSql == null)
				return 0;
			else
			{
				return this.PersonSql.Add(personBo, idUser);
			}
		}

		#endregion
	}
}
