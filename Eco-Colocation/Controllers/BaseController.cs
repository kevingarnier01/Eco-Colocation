using System;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
    public class BaseController : Controller
    {
		#region Properties

		public String WebDbSqlConnectionString { get; set; }

		#endregion

		// GET: Base
		public BaseController()
		{
			this.WebDbSqlConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["EcoColocationModelContainer"].ConnectionString;
        }
    }
}