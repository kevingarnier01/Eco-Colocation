using Eco_Colocation.App_Start;
using Eco_Colocation.BO;
using System.Web.Mvc;

namespace Eco_Colocation.ViewModel
{
	public class AdRentalViewModal
	{
		public RentalAdBo RentalAdBo { get; set; }
		public RentalRoomBo RentalRoomBo { get; set; }

		public SelectList HousingTypeLst { get; set; }
		public SelectList HousingImplantationLst { get; set; }

		public AdRentalViewModal() { }
		public AdRentalViewModal(bool init)
		{
			if (init == true)
			{
				RentalAdBo = new RentalAdBo(true);

				RentalRoomBo = new RentalRoomBo();
				RentalAdBo.RentalRoomBo.Add(RentalRoomBo);
			}
		}

		public void InitLst()
		{
			_Lists _Lists = new _Lists();
			HousingTypeLst = _Lists.HousingTypeLst();
			HousingImplantationLst = _Lists.HousingImplantationLst();
		}
	}
}