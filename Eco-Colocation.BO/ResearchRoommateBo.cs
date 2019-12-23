using System.Collections.Generic;

namespace Eco_Colocation.BO
{
	public class ResearchRoommateBo
	{
		public ResearchRoommateBo()
		{

			this.PlaceBo = new HashSet<PlaceBo>();

		}


		public int IdResearchRoommate { get; set; }

		public int IdPerson { get; set; }

		public short? MaxBudget { get; set; }

		public byte EmailAlert { get; set; }

		public string SearchCriteria { get; set; }

		public string EcoPractice { get; set; }

		public string PictureName { get; set; }

		public bool ActivatedAnnouncement { get; set; }



		public virtual ICollection<PlaceBo> PlaceBo { get; set; }

		public virtual PersonBo PersonBo { get; set; }
	}
}