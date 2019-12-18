namespace Eco_Colocation.BO
{
	public class PlaceBo
	{
		public PlaceBo()
		{
			ResearchRoommateBo = new ResearchRoommateBo();
			CreationProjectAdBo = new CreationProjectAdBo();
		}

		public int IdPlace { get; set; }

		public string City { get; set; }

		public string PostalCode { get; set; }

		public string Department { get; set; }

		public string DepartmentNumber { get; set; }

		public string Region { get; set; }

		public string County { get; set; }

		public byte ScopeResearch { get; set; }


		public virtual CreationProjectAdBo CreationProjectAdBo { get; set; }

		public virtual ResearchRoommateBo ResearchRoommateBo { get; set; }
	}
}