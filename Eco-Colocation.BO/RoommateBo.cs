namespace Eco_Colocation.BO
{
	public class RoommateBo
	{
		public RoommateBo() { }

		public RoommateBo(bool init)
		{
			if (init)
			{

			}
		}

		public int IdRoommate { get; set; }

		public int IdEcoRoommateExisting { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string DateBorn { get; set; }

		public byte Civility { get; set; }
	}
}