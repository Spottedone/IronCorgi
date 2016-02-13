using System;

namespace IronCorgi.Model
{
	/// <summary>
	/// Description of Message.
	/// </summary>
	public class Message
	{
		#region --- properties ---

		public string From { get; set; }
		public string To { get; set; }
		public string Subject { get; set; }
		public DateTime Received { get; set; }

		#endregion

		public Message()
		{
		}
	}
}
