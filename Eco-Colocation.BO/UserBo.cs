﻿using System;
using System.Collections.Generic;

namespace Eco_Colocation.BO
{
	public class UserBo
	{
		public UserBo()
		{

			this.CreationProjectAdBo = new HashSet<CreationProjectAdBo>();

		}


		public int IdUser { get; set; }

		public string Email { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public byte Civility { get; set; }

		public string Country { get; set; }

		public string DateBirth { get; set; }

		public Nullable<byte> Activity { get; set; }

		public string PhoneCode { get; set; }

		public string PhoneNumber { get; set; }

		public Nullable<byte> ContactType { get; set; }

		public string PersonnalityDescription { get; set; }

		public System.DateTime DateInscription { get; set; }

		public System.DateTime DateLastActivity { get; set; }



		public virtual ICollection<CreationProjectAdBo> CreationProjectAdBo { get; set; }
	}
}