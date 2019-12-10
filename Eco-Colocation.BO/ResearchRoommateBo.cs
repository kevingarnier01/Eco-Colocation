using System.Collections.Generic;

namespace Eco_Colocation.Models
{
	public class ResearchRoommateBo
	{
		public ResearchRoommateBo()
		{

			this.PlaceBo = new HashSet<PlaceBo>();

		}


		public int IdResearchRoommate { get; set; }

		public int IdUser { get; set; }

		public short MaxBudget { get; set; }

		public byte EmailAlert { get; set; }

		public string SearchCriteria { get; set; }

		public string EcoPractice { get; set; }

		public string PictureName { get; set; }

		public string ActivatedAnnouncement { get; set; }



		public virtual ICollection<PlaceBo> PlaceBo { get; set; }

		public virtual UserBo UserBo { get; set; }
	}
}