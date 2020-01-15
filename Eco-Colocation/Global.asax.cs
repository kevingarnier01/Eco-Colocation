using System;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMatrix.WebData;

namespace Eco_Colocation
{
	public class MvcApplication : System.Web.HttpApplication
    {
		private static SimpleMembershipInitializer _initializer;
		private static object _initializerLock = new object();
		private static bool _isInitialized;

		protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

			LazyInitializer.EnsureInitialized(ref _initializer, ref _isInitialized, ref _initializerLock);
		}

		protected void Application_Error(object sender, EventArgs e)
		{
			Exception ex = Server.GetLastError();
			//if (ex is HttpException && ((HttpException)ex).GetHttpCode() == 500)
			//{
			//	Response.Redirect("~/Views/Shared/Error.cshtml");
			//}
		}



		public class SimpleMembershipInitializer
		{
			public SimpleMembershipInitializer()
			{
				if (!WebSecurity.Initialized)
					WebSecurity.InitializeDatabaseConnection("ConnStringDb", "User", "IdUser", "UserName", false);
			}
		}
	}
}
