namespace Eco_Colocation.App_Start
{
	public class _Enums
	{
		// ****
		// **** User **** //
		// ****
		public enum TypeUser : int
		{
			Agence = 1,
			Person = 2
		}

		// ****
		// **** Person **** //
		// ****
		public enum ContactType : int
		{
			Both = 0,
			Phone = 1,
			Email = 2
		}

		public enum Activity : int
		{
			Autre = 0,
			Benevole = 1,
			Salarie = 2,
			Independant = 3,
			Etudiant = 4,
			Retraite = 5,
			SansActivite = 6
		}

		public enum Civilite : int
		{
			Madame = 1,
			Monsieur = 2,
			Neutre = 0
		}

		// ****
		// **** Place **** //
		// ****

		public enum ScoopResearch : int
		{
			Commune = 1,
			Departement = 2,
			Region = 3,
			Pays = 4
		}

		// --------------
		// -------------- RentalAd --------------
		// --------------
		public enum HousingType : int
		{
			HabitatInsolite = 1,
			Appartement = 2,
			Maison = 3
		}

		public enum HousingImplantation : int
		{
			Campagne = 1,
			VilleCommune = 2,
		}
	}
}