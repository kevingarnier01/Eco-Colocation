using System;
using System.Reflection;
using System.Web.Mvc;

namespace Eco_Colocation.Controllers
{
	//https://stackoverflow.com/questions/442704/how-do-you-handle-multiple-submit-buttons-in-asp-net-mvc-framework?answertab=oldest#tab-top
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public class MultiButtonAttribute : ActionNameSelectorAttribute
	{
		public string Name { get; set; }
		public string Argument { get; set; }

		public override bool IsValidName(ControllerContext controllerContext, string actionName, MethodInfo methodInfo)
		{
			var isValidName = false;
			var keyValue = string.Format("{0}:{1}", Name, Argument);
			var value = controllerContext.Controller.ValueProvider.GetValue(keyValue);

			if (value != null)
			{
				controllerContext.Controller.ControllerContext.RouteData.Values[Name] = Argument;
				isValidName = true;
			}

			return isValidName;
		}
	}
}