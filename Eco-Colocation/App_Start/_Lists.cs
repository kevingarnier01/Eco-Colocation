using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace Eco_Colocation.App_Start
{
	public class _Lists
	{
		public string Text { get; set; }
		public int Value { get; set; }

		// --------------
		// -------------- CommunSection --------------
		// --------------

		public SelectList ScoopResearchLst()
		{
			return new SelectList(new[]
					   {
						   new _Lists { Text = "Communes", Value = (int)_Enums.ScoopResearch.Commune},
						   new _Lists { Text = "Départements", Value = (int)_Enums.ScoopResearch.Departement },
						   new _Lists { Text = "Régions", Value = (int)_Enums.ScoopResearch.Region },
						   new _Lists { Text = "Tous le pays", Value = (int)_Enums.ScoopResearch.Pays },
					   }, "Value", "Text", null);
		}

		// --------------
		// -------------- Account --------------
		// --------------
		public SelectList ActivityLst()
		{
			return new SelectList(new[]
					   {
						   new _Lists { Text = "Bénévole", Value = (int)_Enums.Activity.Benevole },
						   new _Lists { Text = "Salarié(e)", Value = (int)_Enums.Activity.Salarie },
						   new _Lists { Text = "Indépendant(e)", Value = (int)_Enums.Activity.Independant },
						   new _Lists { Text = "Etudiant(e)", Value = (int)_Enums.Activity.Etudiant },
						   new _Lists { Text = "Retraité(e)", Value = (int)_Enums.Activity.Retraite },
						   new _Lists { Text = "Sans activité", Value = (int)_Enums.Activity.SansActivite },
						   new _Lists { Text = "Autre", Value = (int)_Enums.Activity.Autre },
					   }, "Value", "Text", null);
		}

		public SelectList CivilityLst()
		{
			return new SelectList(new[]
					   {
						   new _Lists { Text = "Madame", Value = (int)_Enums.Civilite.Madame},
						   new _Lists { Text = "Monsieur", Value = (int)_Enums.Civilite.Monsieur },
						   new _Lists { Text = "Neutre", Value = (int)_Enums.Civilite.Neutre },
					   }, "Value", "Text", null);
		}

		public SelectList CountryLst()
		{
			string url = "https://restcountries.eu/rest/v2/all";

			WebClient WebClient = new WebClient();
			string json = WebClient.DownloadString(url);

			byte[] bytes = Encoding.Default.GetBytes(json);
			json = Encoding.UTF8.GetString(bytes);

			List<JObject> countryLst = JsonConvert.DeserializeObject<List<JObject>>(json);

			List<_Lists> lst = new List<_Lists>();

			for (int i = 0; i < countryLst.Count; i++)
			{
				JObject jObject = countryLst[i];

				string pays = jObject["translations"]["fr"].ToString();
				if (pays != "")
					lst.Add(new _Lists { Text = pays, Value = i });
			}

			SelectList lstCountry = new SelectList(lst, "Value", "Text", null);

			return lstCountry;
		}

		public SelectList PhoneCodeLst()
		{

			string url = "https://restcountries.eu/rest/v2/all";

			WebClient WebClient = new WebClient();
			string json = WebClient.DownloadString(url);

			byte[] bytes = Encoding.Default.GetBytes(json);
			json = Encoding.UTF8.GetString(bytes);

			List<JObject> countryLst = JsonConvert.DeserializeObject<List<JObject>>(json);

			List<_Lists> lst = new List<_Lists>();

			for (int i = 0; i < countryLst.Count; i++)
			{
				JObject jObject = countryLst[i];

				string stringCallingCodes = jObject["callingCodes"].ToString();
				string callingCodes = new Regex(@"[0-9]+").Match(stringCallingCodes).Value;

				if (callingCodes != "")
				{
					lst.Add(new _Lists { Text = "+" + callingCodes, Value = System.Convert.ToInt32(callingCodes) });
				}
			}


			lst = lst.OrderBy(l => l.Value).ToList();
			
			//lst  = lst.GroupBy(n => new { n.Text, n.Value }).Select(l => new _Lists() { Text = l.Key.Text, Value = l.Key.Value}).ToList();
			lst = lst.GroupBy(n => n.Text).Select(l => new _Lists() { Text = l.Key }).ToList();

			SelectList phoneCodeLst = new SelectList(lst, "Value", "Text", null);

			return phoneCodeLst;
		}
	}
}