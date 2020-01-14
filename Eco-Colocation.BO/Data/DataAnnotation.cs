using System.Collections;
using System.ComponentModel.DataAnnotations;
using WebMatrix.WebData;

namespace Eco_Colocation.BO.Data
{
	public class ListMinItems : ValidationAttribute
	{
		private readonly int _minElements;
		/// <summary>
		/// Obligation d'avoir un nombre minimum d'item dans une lsite
		/// </summary>
		/// <param name="minElements">Nombre d'item minimum</param>
		public ListMinItems(int minElements)
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

	public class EmailUserUnique : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			var email = value as string;

			if (email != null)
			{
				bool userExists = WebSecurity.UserExists(email);
				if (userExists)
					return false;
				else
					return true;
			}
			return false;
		}
	}
}
