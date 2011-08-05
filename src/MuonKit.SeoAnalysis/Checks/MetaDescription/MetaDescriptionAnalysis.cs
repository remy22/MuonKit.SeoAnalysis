using System.Collections.Generic;

namespace MuonKit.SeoAnalysis.Checks.MetaDescription
{
	public class MetaDescriptionAnalysis : IAnalysis
	{
		/// <summary>
		/// The content of the meta description element
		/// </summary>
		public readonly string Content;

		/// <summary>
		/// The analysis messages for the meta description element
		/// </summary>
		public readonly IEnumerable<Message> Messages;

		/// <summary>
		/// The warning level for the meta description element
		/// </summary>
		public WarningLevel WarningLevel { get { return this.Messages.WarningLevel(); } }

		public MetaDescriptionAnalysis(string content,  params Message[] messages)
		{
			this.Content = content;
			this.Messages = messages;
		}

		public MetaDescriptionAnalysis(string content, IEnumerable<Message> messages)
		{
			this.Content = content;
			this.Messages = messages;
		}
	}
}