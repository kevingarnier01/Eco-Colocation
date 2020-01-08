using System.ComponentModel.DataAnnotations;

namespace Eco_Colocation.BO
{
	public class AgencyBo
	{
		public AgencyBo() { }

		public AgencyBo(bool init)
		{
			if (init)
			{
			}
		}

		public int IdAgency { get; set; }

		public string Name { get; set; }

		[Required(ErrorMessage = "L'email doit être saisi")]
		[StringLength(60, ErrorMessage = "L'email excède le nombre de caractère maximum.")]
		public string Email { get; set; }

		public string Phone { get; set; }

		public string StreetNumber { get; set; }

		public string Street { get; set; }

		public string City { get; set; }

		public string PostalCode { get; set; }

		public string Department { get; set; }

		public string DepartmentNumber { get; set; }

		public string Region { get; set; }

		public string County { get; set; }

		public string SiretNumber { get; set; }

		public decimal AgencyFees { get; set; }

	}
}