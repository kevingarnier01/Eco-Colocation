using Eco_Colocation.BO.Data;
using System.ComponentModel.DataAnnotations;

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
		[DataType(DataType.EmailAddress)]
		[EmailAddress]
		[EmailUserUnique(ErrorMessage = "L'email saisi est déja associé à un compte utilisateur.")]
		//[Remote("EmailValidation", "Account", ErrorMessage = "{0} already has an account, please enter a different email address.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Le mot de passe doit être renseigné.")]
		[StringLength(20, ErrorMessage = "Le mot de passe doit être comprit entre 8 et 20 caractère.", MinimumLength = 8)]
		[DataType(DataType.Password)]
		[RegularExpression(@"[^\w\d]*(([0-9]+.*[A-Za-z]+.*)|[A-Za-z]+.*([0-9]+.*))", ErrorMessage = "Le mot de passe doit comporter des chiffres et des lettres")]
		public string Password { get; set; }

		[Required(ErrorMessage = "La confirmation du mot de passe doit être renseignée.")]
		[Compare("Password", ErrorMessage = "La confirmation du mot de passe n'est pas valide.")]
		[DataType(DataType.Password)]
		public string PasswordConfirm { get; set; }
		
		public byte TypeUser { get; set; }

		public bool Activated { get; set; }


		public virtual PersonBo PersonBo { get; set; }

		public virtual AgencyBo AgencyBo { get; set; }
	}
}