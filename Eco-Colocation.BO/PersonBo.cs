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
		
		[Required(ErrorMessage = "Le prénom doit être renseigné")]
		[DataType(DataType.Text)]
		[MaxLength(50, ErrorMessage = "Le prénom ne peut excéder 50 caractères")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Le nom doit être renseigné")]
		[DataType(DataType.Text)]
		[MaxLength(50, ErrorMessage = "Le nom ne peut excéder 50 caractères")]
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
		[DataType(DataType.PhoneNumber)]
		[MaxLength(12, ErrorMessage = "Le numéro de téléphone ne peut excéder 12 chiffres")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Le mode de contact doit être renseigné")]
		public byte ContactType { get; set; }

		[Required(ErrorMessage = "La description de votre personnalité doit être renseignée")]
		[DataType(DataType.Text)]
		[MaxLength(500, ErrorMessage = "La description de votre personnalité ne peut excéder 500 caractères")]
		public string PersonnalityDescription { get; set; }

		public System.DateTime DateInscription { get; set; }

		public System.DateTime DateLastActivity { get; set; }
	}
}