using MuonKit.SeoAnalysis.Checks.AltAttributes;
using MuonKit.SeoAnalysis.Checks.Headers;
using MuonKit.SeoAnalysis.Checks.Title;

namespace MuonKit.SeoAnalysis
{
	public sealed class HtmlAnalysis
	{
		public readonly TitleAnalysis Title;
		public readonly HeadersAnalysis Headers;
		public readonly AltAttributesAnalysis AltAttributes;

		public HtmlAnalysis(TitleAnalysis title, HeadersAnalysis headers, AltAttributesAnalysis altAttributes)
		{
			this.Title = title;
			this.Headers = headers;
			this.AltAttributes = altAttributes;
		}

		public WarningLevel WarningLevel
		{
			get
			{
				return 
					this.Title.WarningLevel | 
					this.Headers.WarningLevel |
					this.AltAttributes.WarningLevel;
			}
		}
	}
}