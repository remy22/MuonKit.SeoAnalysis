using System.Collections.Generic;

namespace MuonKit.SeoAnalysis.Checks.Headers
{
	public class HeaderAnalysis : IAnalysis
	{
		/// <summary>
		/// The text of this header element
		/// </summary>
		public readonly string Header;

		/// <summary>
		/// The analysis messages for this element
		/// </summary>
		public readonly IEnumerable<Message> Messages;

		/// <summary>
		/// The warning level for this element
		/// </summary>
		public WarningLevel WarningLevel { get { return this.Messages.WarningLevel(); } }

		public HeaderAnalysis(string header, params Message[] messages)
		{
			this.Header = header;
			this.Messages = messages;
		}
	}
}