
namespace Eco_Colocation.BO
{
	public class PictureDevConversationBo
	{
		public PictureDevConversationBo(){}

		public PictureDevConversationBo(bool init)
		{
			if (init)
			{
			}
		}

		public int IdPictureDevConversation { get; set; }

		public int IdDevConversation { get; set; }

		public string PictureName { get; set; }
	}
}