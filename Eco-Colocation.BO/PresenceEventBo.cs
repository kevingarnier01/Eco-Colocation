
namespace Eco_Colocation.BO
{
	public class PresenceEventBo
	{
		public int IdPerson { get; set; }

		public int IdEvent { get; set; }

		public byte Status { get; set; }



		public virtual EventBo EventBo { get; set; }

		public virtual PersonBo PersonBo { get; set; }
	}
}