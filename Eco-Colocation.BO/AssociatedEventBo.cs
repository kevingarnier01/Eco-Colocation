﻿namespace Eco_Colocation.BO
{
	public class AssociatedEventBo
	{
		public int IdEvent { get; set; }

		public int IdAssociatedEvent { get; set; }


		public virtual EventBo EventBo { get; set; }

		public virtual EventBo Event1Bo { get; set; }
	}
}