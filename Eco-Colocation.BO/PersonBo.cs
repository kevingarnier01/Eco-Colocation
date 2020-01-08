﻿using System;
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
		[Required(ErrorMessage = "L'email doit être saisi")]
		[StringLength(60, ErrorMessage = "L'email excède le nombre de caractère maximum.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Le prénom doit être saisi")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Le nom doit être saisi")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "La civilité doit être saisie")]
		public byte Civility { get; set; }

		[Required(ErrorMessage = "Le pays doit être saisi")]
		public string Country { get; set; }

		[Required(ErrorMessage = "La date de naissance doit être saisie")]
		public System.DateTime DateBorn { get; set; }

		[Required(ErrorMessage = "L'activité doit être selectionné")]
		public byte Activity { get; set; }

		[Required(ErrorMessage = "L'indicatif téléphonique doit être selectionné")]
		public string PhoneCode { get; set; }

		[Required(ErrorMessage = "Le numéro de téléphone doit être saisi")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Le type de contact possible doit être coché")]
		public byte ContactType { get; set; }

		[Required(ErrorMessage = "Le description de votre personnalité doit être saisi")]
		public string PersonnalityDescription { get; set; }

		public System.DateTime DateInscription { get; set; }

		public System.DateTime DateLastActivity { get; set; }
	}
}