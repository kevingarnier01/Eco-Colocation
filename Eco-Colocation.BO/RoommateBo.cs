namespace Eco_Colocation.Models
{
	public class RoommateBo
	{
		public int IdRoommate { get; set; }

		public int IdEcoRoommateExisting { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string DateBirth { get; set; }

		public byte Civility { get; set; }
		

		public virtual EcoRoommateExistingBo EcoRoommateExistingBo { get; set; }
	}
}