using System;

namespace Eco_Colocation.BO
{
	public class RentalRoomBo
	{
		public RentalRoomBo() { }

		public RentalRoomBo(bool init)
		{
			if (init)
			{
			}
		}

		public int IdRentalRoom { get; set; }

		public int IdRentalAd { get; set; }

		public decimal? RentPrice { get; set; }

		public decimal? Charges { get; set; }

		public string ChargesDetail { get; set; }

		public Nullable<decimal> Caution { get; set; }

		public short? Surface { get; set; }

		public bool Furnished { get; set; }

		public System.DateTime AvalaibleDate { get; set; }

		public Nullable<DateTime> AvalaibleEndDate { get; set; }
	}
}