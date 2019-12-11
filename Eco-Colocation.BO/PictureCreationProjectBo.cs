
namespace Eco_Colocation.BO
{
	public class PictureCreationProjectBo
	{
		public int IdPictureCreationProject { get; set; }

		public int IdProjetCreation { get; set; }

		public string PictureName { get; set; }

		public byte OrderNumber { get; set; }


		public virtual CreationProjectAdBo CreationProjectAdBo { get; set; }
	}
}