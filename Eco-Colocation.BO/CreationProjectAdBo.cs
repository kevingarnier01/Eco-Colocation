using System;
using System.Collections.Generic;

namespace Eco_Colocation.Models
{
	public class CreationProjectAdBo
	{
		public CreationProjectAdBo()
		{

			this.PlaceBo = new HashSet<PlaceBo>();

		}


		public int IdCreationProject { get; set; }

		public int IdUser { get; set; }

		public string Introduction { get; set; }

		public string Description { get; set; }

		public Nullable<byte> LandEngagement { get; set; }

		public Nullable<int> LandMaxSurface { get; set; }

		public Nullable<int> LandMaxPrice { get; set; }

		public byte HousingEngagement { get; set; }

		public byte HousingType { get; set; }

		public byte HousingImplantation { get; set; }

		public short HousingMaxSurface { get; set; }

		public Nullable<int> HousingMaxPrice { get; set; }

		public Nullable<short> HousingMaxRent { get; set; }

		public Nullable<int> HousingMaxPriceBuilt { get; set; }

		public short TotalNumberPerson { get; set; }

		public Nullable<short> NbPersonToBuyLand { get; set; }

		public Nullable<short> NbPersonToBuyHousing { get; set; }

		public Nullable<short> NbPersonToRentHousing { get; set; }

		public byte AccesPublicTransport { get; set; }

		public string AccesInfoSup { get; set; }

		public bool TolerationAlcoholConsommation { get; set; }

		public bool TolerationSmoker { get; set; }

		public bool TolerationPets { get; set; }

		public string TolerationInfoSup { get; set; }

		public string ActivatedAnnouncement { get; set; }



		public virtual ICollection<PlaceBo> PlaceBo { get; set; }
	}
}