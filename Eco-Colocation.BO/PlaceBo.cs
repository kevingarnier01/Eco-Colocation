using System.Collections.Generic;

namespace Eco_Colocation.Models
{
	public class PlaceBo
	{
		public PlaceBo()
		{

			this.CreationProjectAdBo = new HashSet<CreationProjectAdBo>();

			this.ResearchRoommateBo = new HashSet<ResearchRoommateBo>();

		}


		public int IdPlace { get; set; }

		public string City { get; set; }

		public string PostalCode { get; set; }

		public string Department { get; set; }

		public string DepartmentNumber { get; set; }

		public string Region { get; set; }

		public string County { get; set; }



		public virtual ICollection<CreationProjectAdBo> CreationProjectAdBo { get; set; }

		public virtual ICollection<ResearchRoommateBo> ResearchRoommateBo { get; set; }
	}
}