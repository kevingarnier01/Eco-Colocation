
namespace Eco_Colocation.BO
{
	public class PictureDevConversationBo
	{
		public int IdPictureDevConversation { get; set; }

		public int IdDevConversation { get; set; }

		public string PictureName { get; set; }
			   
		public virtual DevConversationBo DevConversationBo { get; set; }
	}
}