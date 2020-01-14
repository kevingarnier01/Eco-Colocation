using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eco_Colocation.BO
{
	public class EventBo
	{
		public EventBo() { }

		public EventBo(bool init)
		{
			if (init)
			{
				this.PresenceEventBo = new HashSet<PresenceEventBo>();

				this.AssociatedEventBo = new HashSet<AssociatedEventBo>();

				this.AssociatedEvent1Bo = new HashSet<AssociatedEventBo>();

				PersonBo = new PersonBo(true);
			}
		}


		public int IdEvent { get; set; }

		public int IdUser { get; set; }

		public System.DateTime DateStart { get; set; }

		public System.DateTime DateEnd { get; set; }

		public string StreetNumber { get; set; }

		public string StreetName { get; set; }

		public string City { get; set; }

		public string PostalCode { get; set; }

		public string Department { get; set; }

		public string DepartmentNumber { get; set; }

		public string Region { get; set; }

		public string Country { get; set; }

		[DataType(DataType.Url)]
		public string Link { get; set; }

		public string Description { get; set; }

		public string PictureName { get; set; }

		public System.DateTime DatePublish { get; set; }



		public virtual ICollection<PresenceEventBo> PresenceEventBo { get; set; }

		public virtual ICollection<AssociatedEventBo> AssociatedEventBo { get; set; }

		public virtual ICollection<AssociatedEventBo> AssociatedEvent1Bo { get; set; }

		public virtual PersonBo PersonBo { get; set; }
	}
}