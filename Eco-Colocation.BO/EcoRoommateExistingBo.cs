using System.Collections.Generic;

namespace Eco_Colocation.BO
{
	public class EcoRoommateExistingBo
	{
		public EcoRoommateExistingBo() { }

		public EcoRoommateExistingBo(bool init)
		{
			if (init)
			{
				this.PictureEcoRoommateExBo = new HashSet<PictureEcoRoommateExBo>();

				this.RoommateBo = new HashSet<RoommateBo>();

				PersonBo = new PersonBo(true);
			}
		}


		public int IdEcoRoommateExisting { get; set; }

		public int IdPerson { get; set; }

		public string EcoRoommateName { get; set; }

		public short RommateNumber { get; set; }

		public string Country { get; set; }

		public string Region { get; set; }

		public string Department { get; set; }

		public string DepartmentNumber { get; set; }

		public string City { get; set; }

		public string PostalCode { get; set; }

		public string Email { get; set; }

		public string Description { get; set; }

		public byte EcoImplication { get; set; }

		public string TableEco { get; set; }

		public string TableHousing { get; set; }



		public virtual ICollection<PictureEcoRoommateExBo> PictureEcoRoommateExBo { get; set; }

		public virtual PersonBo PersonBo { get; set; }

		public virtual ICollection<RoommateBo> RoommateBo { get; set; }
	}
}