
namespace Eco_Colocation.BO
{
	public class PictureEcoRoommateExBo
	{
		public PictureEcoRoommateExBo() { }

		public PictureEcoRoommateExBo(bool init)
		{
			if (init)
			{
			}
		}

		public int IdPictureEcoRoommateEx { get; set; }

		public int IdEcoRoommateExisting { get; set; }

		public string PictureName { get; set; }

		public byte OrderNumber { get; set; }
	}
}