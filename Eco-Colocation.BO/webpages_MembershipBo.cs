using System;

namespace Eco_Colocation.BO
{
	public class webpages_MembershipBo
	{
		public int UserId { get; set; }

		public Nullable<System.DateTime> CreateDate { get; set; }

		public string ConfirmationToken { get; set; }

		public Nullable<bool> IsConfirmed { get; set; }

		public Nullable<System.DateTime> LastPasswordFailureDate { get; set; }

		public int PasswordFailuresSinceLastSuccess { get; set; }

		public string Password { get; set; }
		
		public string PasswordConfirm { get; set; }

		public Nullable<System.DateTime> PasswordChangedDate { get; set; }

		public string PasswordSalt { get; set; }

		public string PasswordVerificationToken { get; set; }

		public Nullable<System.DateTime> PasswordVerificationTokenExpirationDate { get; set; }


		public virtual UserBo UserBo { get; set; }
	}
}
