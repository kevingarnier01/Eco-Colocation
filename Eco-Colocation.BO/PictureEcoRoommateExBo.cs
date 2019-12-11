
namespace Eco_Colocation.BO
{
	public class PictureEcoRoommateExBo
	{
		public int IdPictureEcoRoommateEx { get; set; }

		public int IdEcoRoommateExisting { get; set; }

		public string PictureName { get; set; }

		public byte OrderNumber { get; set; }

		public virtual EcoRoommateExistingBo EcoRoommateExistingBo { get; set; }
	}
}