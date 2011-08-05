using System.Collections.Generic;
using System.Linq;

namespace MuonKit.SeoAnalysis.Checks.Headers
{
	public sealed class HeaderTypeAnalysis : IAnalysis
	{
		/// <summary>
		/// Collection of analysis of the headers of this type found in the document
		/// </summary>
		public readonly IEnumerable<HeaderAnalysis> Headers;

		/// <summary>
		/// The warning level for this type of header
		/// </summary>
		public WarningLevel WarningLevel
		{
			get { return this.Headers.WarningLevel() | this.Messages.WarningLevel(); }
		}

		/// <summary>
		/// Collection of analysis messages for this type of header.
		/// Does not include messages about individual tag analysis. See the Messages property on the Headers property for that.
		/// </summary>
		public readonly IEnumerable<Message> Messages;

		public HeaderTypeAnalysis(IEnumerable<HeaderAnalysis> headers, params Message[] messages)
		{
			this.Headers = headers;
			this.Messages = messages;
		}
	}
}