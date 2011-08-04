using System.Collections.Generic;

namespace MuonKit.SeoAnalysis.Checks.Headers
{
	public sealed class HeaderAnalysis
	{
		public readonly IEnumerable<string> Headers;

		public readonly WarningLevel WarningLevel;
		public readonly string Message;

		public HeaderAnalysis(IEnumerable<string> headers, WarningLevel warningLevel, string message)
		{
			this.Headers = headers;
			this.WarningLevel = warningLevel;
			this.Message = message;
		}
	}
}