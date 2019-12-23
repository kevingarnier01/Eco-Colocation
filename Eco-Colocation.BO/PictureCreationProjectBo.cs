
namespace Eco_Colocation.BO
{
	public class PictureCreationProjectBo
	{
		public PictureCreationProjectBo() { }

		public PictureCreationProjectBo(bool init)
		{
			if (init)
			{
			}
		}

		public int IdPictureCreationProject { get; set; }

		public int IdProjetCreation { get; set; }

		public string PictureName { get; set; }

		public byte OrderNumber { get; set; }
	}
}