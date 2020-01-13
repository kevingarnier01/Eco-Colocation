﻿using System.ComponentModel.DataAnnotations;

namespace Eco_Colocation.BO
{
	public class UserBo
	{
		public UserBo(){}
		public UserBo(bool init)
		{
			if (init)
			{
				this.Activated = true;

				PersonBo = new PersonBo(true);

				AgencyBo = new AgencyBo(true);

				TypeUser = 2;
			}
		}

		public int IdUser { get; set; }

		[Required(ErrorMessage = "Le nom d'utilisateur doit être renseigné.")]
		[StringLength(60, ErrorMessage = "L'email excède le nombre de caractère maximum.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Le mot de passe doit être renseigné.")]
		[StringLength(40, ErrorMessage = "La confirmation du mot de passe excède le nombre de caractère maximum.")]
		public string Password { get; set; }

		[Required(ErrorMessage = "La confirmation du mot de passe doit être renseignée.")]
		[StringLength(40, ErrorMessage = "La confirmation du mot de passe excède le nombre de caractère maximum.")]
		public string PasswordConfirm { get; set; }
		
		public byte TypeUser { get; set; }

		public bool Activated { get; set; }


		public virtual PersonBo PersonBo { get; set; }

		public virtual AgencyBo AgencyBo { get; set; }
	}
}