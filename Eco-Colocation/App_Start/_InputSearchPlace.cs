using Eco_Colocation.BO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Eco_Colocation.App_Start._Enums;

namespace Eco_Colocation.App_Start
{
	public class _InputSearchPlace
	{
		public PlaceBo GetObjectFromPlaceJson(string jsonDataPlace, int ScopeResearch)
		{
			JObject place = JsonConvert.DeserializeObject<JObject>(jsonDataPlace);

			PlaceBo placeBo = new PlaceBo(true);
			if (ScopeResearch == (int)ScoopResearch.Commune)
			{
				placeBo.City = (string)place["label"];
				placeBo.PostalCode = (string)place["postcode"];
				string[] context = place["context"].ToString().Split(',');
				if (context != null)
				{
					placeBo.DepartmentNumber = (context.Length >= 1) ? context[0] : "";
					placeBo.Department = (context.Length >= 2) ? context[1] : "";
					placeBo.Region = (context.Length >= 3) ? context[2] : "";
				}
			}
			else if (ScopeResearch == (int)ScoopResearch.Departement)
			{
				placeBo.Department = (string)place["nom"];
				placeBo.DepartmentNumber = (string)place["code"];
			}
			else if (ScopeResearch == (int)ScoopResearch.Region)
			{
				placeBo.Region = (string)place["nom"];

				
			}

			return placeBo;
		}

		public PlaceBo GetFullPlaceName(PlaceBo placeBo)
		{
			if (placeBo.ScopeResearch == (int)ScoopResearch.Commune)
			{
				placeBo.FullPlaceName = placeBo.City + ", " + placeBo.DepartmentNumber + " - " + placeBo.Department + ", " + placeBo.Region + ", " + placeBo.Country;
			}
			else if (placeBo.ScopeResearch == (int)ScoopResearch.Departement)
			{
				placeBo.FullPlaceName = placeBo.DepartmentNumber + " - " + placeBo.Department + ", " + placeBo.Country;
			}
			else if (placeBo.ScopeResearch == (int)ScoopResearch.Region)
			{
				placeBo.FullPlaceName = placeBo.Region + ", " + placeBo.Country;
			}

			return placeBo;
		}
	}
}