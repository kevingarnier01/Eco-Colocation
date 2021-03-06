﻿using Eco_Colocation.DAL;

namespace Eco_Colocation.BLL
{
	public class RentalAdManager
	{
		#region Properties

 //  'RentalAdSql' 
		private RentalAdSql RentalAdSql { get; set; }
 //  'RentalAdSql' 

		#endregion

		#region Initialization

		public RentalAdManager(RentalAdSql poRentalAdSql)
			: this()
		{
			this.RentalAdSql = poRentalAdSql;
		}

		private RentalAdManager()
		{
			this.InitData();
		}

		private void InitData()
		{
			this.RentalAdSql = null;
		}

		#endregion
	}
}
