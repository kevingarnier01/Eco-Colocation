using System;

namespace Eco_Colocation.BO
{
	public class PersonBo
	{
		public PersonBo() { }

		public PersonBo(bool init)
		{
			if (init)
			{
				Civility = 1;
				Country = "France";
				PhoneCode = "+33";
				ContactType = 0;
			}
		}

		public int IdPerson { get; set; }

		public string Email { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public byte Civility { get; set; }

		public string Country { get; set; }

		public System.DateTime DateBirth { get; set; }

		public byte Activity { get; set; }

		public string PhoneCode { get; set; }

		public string PhoneNumber { get; set; }

		public byte ContactType { get; set; }

		public string PersonnalityDescription { get; set; }

		public System.DateTime DateInscription { get; set; }

		public System.DateTime DateLastActivity { get; set; }
	}
}