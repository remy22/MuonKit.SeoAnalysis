using System.Collections.Generic;
using System.Linq;

namespace MuonKit.SeoAnalysis.Checks.Title
{
	public sealed class TitleAnalysis : IAnalysis
	{
		/// <summary>
		/// The text of teh title element
		/// </summary>
		public readonly string Title;

		/// <summary>
		/// The analysis messages for the title
		/// </summary>
		public readonly IEnumerable<Message> Messages;

		public TitleAnalysis(string title, IEnumerable<Message> messages)
		{
			this.Title = title;
			this.Messages = messages;
		}

		/// <summary>
		/// The warning level for the title element
		/// </summary>
		public WarningLevel WarningLevel
		{
			get
			{
				return this.Messages.Aggregate(WarningLevel.Ok, (current, mesage) => current | mesage.WarningLevel);
			}
		}
	}
}