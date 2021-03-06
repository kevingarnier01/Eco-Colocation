﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eco_Colocation.BO
{
	public class ResearchRoommateBo
	{
		public ResearchRoommateBo() { }

		public ResearchRoommateBo(bool init)
		{
			if (init)
			{

				this.PlaceBo = new HashSet<PlaceBo>();

				//this.PersonBo = new PersonBo(true);

				this.EmailAlert = 1;
			}
		}


		public int IdResearchRoommate { get; set; }

		public int IdPerson { get; set; }
				
		[Required(ErrorMessage = "Le budget max doit être renseigné")]
		[Range(0, 10000, ErrorMessage = "Le budget max doit être entre 0 et 10 000 €")]
		public short? MaxBudget { get; set; }

		public byte EmailAlert { get; set; }

		[Required(ErrorMessage = "Le type d'éco-colocation recherché doivent être renseignés")]
		[MaxLength(3500, ErrorMessage = "Le type d'éco-colocation recherché ne peut excéder 3500 caractère. {0} {1}")]
		public string SearchCriteria { get; set; }

		[Required(ErrorMessage = "Les pratiques écologiques doivent être renseignées")]
		[MaxLength(3500, ErrorMessage = "Vos pratiques écologiqes ne peuvent excéder 3500 caractère. {0} {1}")]
		public string EcoPractice { get; set; }
		
		[StringLength(50, ErrorMessage = "Le nom de la photo ne peut excéder 50 caractères.")]
		public string PictureName { get; set; }

		public bool ActivatedAnnouncement { get; set; }

		public virtual ICollection<PlaceBo> PlaceBo { get; set; }

		public virtual PersonBo PersonBo { get; set; }
	}
}