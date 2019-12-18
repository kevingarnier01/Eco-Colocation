using Eco_Colocation.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco_Colocation.BLL
{
	public class PictureCreationProjectManager
	{
		#region Properties

 //  'PictureCreationProjectSql' 
		private PictureCreationProjectSql PictureCreationProjectSql { get; set; }
 //  'PictureCreationProjectSql' 

		#endregion

		#region Initialization

 //  'PictureCreationProjectSql' 
		public PictureCreationProjectManager(PictureCreationProjectSql poPictureCreationProjectSql)
 //  'PictureCreationProjectSql' 
			: this()
		{
			this.PictureCreationProjectSql = poPictureCreationProjectSql;
		}

		private PictureCreationProjectManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.PictureCreationProjectSql = null;
		}

		#endregion
	}
}
