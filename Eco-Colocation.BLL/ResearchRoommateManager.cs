﻿using System;
using Eco_Colocation.BO;
using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class ResearchRoommateManager
	{
		#region Properties

		//  'ResearchRoommateSql' 
		private ResearchRoommateSql ResearchRoommateSql { get; set; }
		//  'ResearchRoommateSql' 

		#endregion

		#region Initialization

		public ResearchRoommateManager(ResearchRoommateSql poResearchRoommateSql)
			: this()
		{
			this.ResearchRoommateSql = poResearchRoommateSql;
		}

		private ResearchRoommateManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.ResearchRoommateSql = null;
		}

		#endregion

		#region Methods

		public int Add(ResearchRoommateBo researchRoommateBo, int idPerson)
		{
			if (this.ResearchRoommateSql == null)
				return 0;
			else
			{
				return this.ResearchRoommateSql.Add(researchRoommateBo, idPerson);
			}
		}

		public int Upd(ResearchRoommateBo researchRoommateBo, int idPerson)
		{
			if (this.ResearchRoommateSql == null)
				return 0;
			else
			{
				return this.ResearchRoommateSql.Upd(researchRoommateBo, idPerson);
			}
		}

		public ResearchRoommateBo GetByPersonId(int idPerson)
		{
			if (this.ResearchRoommateSql == null)
				return null;
			else
			{
				return this.ResearchRoommateSql.GetByPersonId(idPerson);
			}
		}

		#endregion
	}
}
