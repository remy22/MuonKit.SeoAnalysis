using System.Collections.Generic;
using MuonKit.SeoAnalysis.Checks.AltAttributes;
using MuonKit.SeoAnalysis.Checks.Headers;
using MuonKit.SeoAnalysis.Checks.MetaDescription;
using MuonKit.SeoAnalysis.Checks.Title;

namespace MuonKit.SeoAnalysis
{
	public sealed class HtmlAnalysisReport : IAnalysis
	{
		/// <summary>
		/// Analysis results for the Title element
		/// </summary>
		public readonly TitleAnalysis Title;
		
		/// <summary>
		/// Analysis results for Header elements
		/// </summary>
		public readonly HeadersAnalysis Headers;

		/// <summary>
		/// Analysis results for Alt attributes on Img elements
		/// </summary>
		public readonly IEnumerable<AltAttributeAnalysis> AltAttributes;
		
		/// <summary>
		/// Analysus results for the meta description element
		/// </summary>
		public readonly MetaDescriptionAnalysis MetaDescAnalysis;

		/// <summary>
		/// Creates a new report
		/// </summary>
		/// <param name="title"></param>
		/// <param name="headers"></param>
		/// <param name="altAttributes"></param>
		/// <param name="metaDescAnalysis"></param>
		public HtmlAnalysisReport(TitleAnalysis title, HeadersAnalysis headers, IEnumerable<AltAttributeAnalysis> altAttributes, MetaDescriptionAnalysis metaDescAnalysis)
		{
			this.Title = title;
			this.Headers = headers;
			this.AltAttributes = altAttributes;
			this.MetaDescAnalysis = metaDescAnalysis;
		}

		/// <summary>
		/// The aggregated warning level
		/// </summary>
		public WarningLevel WarningLevel
		{
			get
			{
				return 
					this.Title.WarningLevel | 
					this.Headers.WarningLevel |
					this.AltAttributes.WarningLevel() | 
					this.MetaDescAnalysis.WarningLevel;
			}
		}
	}
}