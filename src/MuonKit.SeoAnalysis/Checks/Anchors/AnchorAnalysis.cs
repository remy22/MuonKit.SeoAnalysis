using System.Collections.Generic;

namespace MuonKit.SeoAnalysis.Checks.Anchors
{
	public sealed class AnchorAnalysis : IAnalysis
	{
		/// <summary>
		/// The text of the anchor element
		/// </summary>
		public readonly string Text;

		/// <summary>
		/// The Href attribute of the anchor element
		/// </summary>
		public readonly string Href;

		/// <summary>
		/// The Rel attribute of the anchor element
		/// </summary>
		public readonly string Rel;

		/// <summary>
		/// The title attribute of the anchor element
		/// </summary>
		public readonly string Title;

		/// <summary>
		/// The analysis messages for the anchor element
		/// </summary>
		public readonly IEnumerable<Message> Messages;

		public AnchorAnalysis(string text, string title, string href, string rel, params Message[] messages)
		{
			this.Text = text;
			this.Title = title;
			this.Href = href;
			this.Rel = rel;
			this.Messages = messages;
		}

		/// <summary>
		/// The warning level for the anchor element
		/// </summary>
		public WarningLevel WarningLevel
		{
			get { return this.Messages.WarningLevel(); }
		}
	}
}