using System.Collections.Generic;

namespace Eco_Colocation.BO
{
	public class RentalAdBo
	{
		public RentalAdBo() { }

		public RentalAdBo(bool init)
		{
			if (init)
			{
				this.RentalRoomBo = new List<RentalRoomBo>();

				UserBo = new UserBo(true);
			}
		}


		public int IdRentalAd { get; set; }

		public int IdUser { get; set; }

		public string Introduction { get; set; }

		public string Description { get; set; }

		public string Street { get; set; }

		public string City { get; set; }

		public string PostalCode { get; set; }

		public string Department { get; set; }

		public string DepartmentNumber { get; set; }

		public string Region { get; set; }

		public string Country { get; set; }

		public decimal Latitude { get; set; }

		public decimal Longitude { get; set; }

		public byte HousingType { get; set; }

		public byte HousingImplantation { get; set; }

		public short HousingSurface { get; set; }

		public int LandSurface { get; set; }

		public short HousingPieceNumber { get; set; }

		public short RoommateNumberStaying { get; set; }

		public short RoommateNumberResearched { get; set; }

		public bool AccessHandicapped { get; set; }

		public bool AccesPublicTransport { get; set; }

		public string AccesInfoSup { get; set; }

		public bool TolerationAlcoholConsommation { get; set; }

		public bool TolerationSmoker { get; set; }

		public bool TolerationPets { get; set; }

		public string TolerationInfoSup { get; set; }

		public System.DateTime DatePublish { get; set; }

		public bool ActivatedAnnouncement { get; set; }


		public virtual List<RentalRoomBo> RentalRoomBo { get; set; }

		public virtual UserBo UserBo { get; set; }
	}
}