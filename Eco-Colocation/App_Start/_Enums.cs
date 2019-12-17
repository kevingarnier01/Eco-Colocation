namespace Eco_Colocation.App_Start
{
	public class _Enums
	{
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
	}
}