using System;
using System.ComponentModel.DataAnnotations;

namespace Eco_Colocation.BO
{
	public class PlaceBo
	{
		public PlaceBo() { }

		public PlaceBo(bool init)
		{
			if (init)
			{
				ScopeResearch = 1;
				Country = "France";
			}
		}

		public int IdPlace { get; set; }

		public Nullable<int> IdResearchRoommate { get; set; }

		public Nullable<int> IdCreationProject { get; set; }

		public string City { get; set; }

		[DataType(DataType.PostalCode)]
		public string PostalCode { get; set; }

		public string Department { get; set; }

		public string DepartmentNumber { get; set; }

		public string Region { get; set; }

		public string Country { get; set; }

		[Required(ErrorMessage = "Le type de zone géographique pour l'adresse doit être renseigné")]
		public byte ScopeResearch { get; set; }
				
		public string JsonDataPlace { get; set; }
		
		public string FullPlaceName { get; set; }
	}
}