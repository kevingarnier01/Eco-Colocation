
namespace Eco_Colocation.BO
{
	public class PresenceEventBo
	{
		public int IdUser { get; set; }

		public int IdEvent { get; set; }

		public byte Status { get; set; }



		public virtual EventBo EventBo { get; set; }

		public virtual UserBo UserBo { get; set; }
	}
}