using System.Collections.Generic;

namespace Eco_Colocation.BO
{
	public class DevConversationBo
	{
		public DevConversationBo() { }

		public DevConversationBo(bool init)
		{
			if (init)
			{
				this.Viewed = 0;

				this.PictureDevConversationBo = new HashSet<PictureDevConversationBo>();
			}
		}


		public int IdDevConversation { get; set; }

		public string Email { get; set; }

		public string Message { get; set; }

		public System.DateTime DateLastSend { get; set; }

		public byte Viewed { get; set; }



		public virtual ICollection<PictureDevConversationBo> PictureDevConversationBo { get; set; }
	}
}