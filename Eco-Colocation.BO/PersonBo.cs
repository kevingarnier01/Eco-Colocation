using System;
using System.ComponentModel.DataAnnotations;

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

		[EmailAddress(ErrorMessage = "L'email n'est pas valide")]
		[Required(ErrorMessage = "L'email doit être renseigné")]
		[StringLength(60, ErrorMessage = "L'email excède le nombre de caractère maximum.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Le prénom doit être renseigné")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Le nom doit être renseigné")]
		public string LastName { get; set; }

		public byte Civility { get; set; }

		public string Country { get; set; }

		[Required(ErrorMessage = "La date de naissance doit être renseignée")]
		[DataType(DataType.Date, ErrorMessage = "La date de naissance n'est pas valide")]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public System.DateTime DateBorn { get; set; }

		public byte Activity { get; set; }

		public string PhoneCode { get; set; }

		[Required(ErrorMessage = "Le numéro de téléphone doit être renseigné")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Le mode de contact doit être renseigné")]
		public byte ContactType { get; set; }

		[Required(ErrorMessage = "La description de votre personnalité doit être renseignée")]
		public string PersonnalityDescription { get; set; }

		public System.DateTime DateInscription { get; set; }

		public System.DateTime DateLastActivity { get; set; }
	}
}