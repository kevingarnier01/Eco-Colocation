namespace Eco_Colocation.BO
{
	public class AssociatedEventBo
	{
		public AssociatedEventBo() { }

		public AssociatedEventBo(bool init)
		{
			if (init)
			{
			}
		}

		public int IdEvent { get; set; }

		public int IdAssociatedEvent { get; set; }


		public virtual EventBo EventBo { get; set; }

		public virtual EventBo Event1Bo { get; set; }
	}
}