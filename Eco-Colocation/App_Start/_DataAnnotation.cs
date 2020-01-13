using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Eco_Colocation.App_Start
{
	public class RequiredListMinItems : ValidationAttribute
	{
		private readonly int _minElements;
		/// <summary>
		/// Obligation d'avoir un nombre minimum d'item dans une lsite
		/// </summary>
		/// <param name="minElements">Nombre d'item minimum</param>
		public RequiredListMinItems(int minElements)
		{
			_minElements = minElements;
		}

		public override bool IsValid(object value)
		{
			var list = value as IList;
			if (list != null)
			{
				return list.Count >= _minElements;
			}
			return false;
		}
	}
}