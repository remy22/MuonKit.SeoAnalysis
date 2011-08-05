using MuonKit.SeoAnalysis.Checks.AltAttributes;
using MuonKit.SeoAnalysis.Checks.Headers;
using MuonKit.SeoAnalysis.Checks.MetaDescription;
using MuonKit.SeoAnalysis.Checks.Title;

namespace MuonKit.SeoAnalysis
{
	public sealed class HtmlAnalysis
	{
		public readonly TitleAnalysis Title;
		public readonly HeadersAnalysis Headers;
		public readonly AltAttributesAnalysis AltAttributes;
		public readonly MetaDescriptionAnalysis MetaDescAnalysis;

		public HtmlAnalysis(TitleAnalysis title, HeadersAnalysis headers, AltAttributesAnalysis altAttributes, MetaDescriptionAnalysis metaDescAnalysis)
		{
			this.Title = title;
			this.Headers = headers;
			this.AltAttributes = altAttributes;
			this.MetaDescAnalysis = metaDescAnalysis;
		}

		public WarningLevel WarningLevel
		{
			get
			{
				return 
					this.Title.WarningLevel | 
					this.Headers.WarningLevel |
					this.AltAttributes.WarningLevel | 
					this.MetaDescAnalysis.WarningLevel;
			}
		}
	}
}