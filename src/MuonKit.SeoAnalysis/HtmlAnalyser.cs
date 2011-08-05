using System;
using HtmlAgilityPack;
using MuonKit.SeoAnalysis.Checks.AltAttributes;
using MuonKit.SeoAnalysis.Checks.Headers;
using MuonKit.SeoAnalysis.Checks.MetaDescription;
using MuonKit.SeoAnalysis.Checks.Title;

namespace MuonKit.SeoAnalysis
{
	public class HtmlAnalyser : IHtmlAnalyser
	{
		readonly ITitleCheck titleCheck;
		readonly IHeadersCheck headersCheck;
		readonly IAltAttributesCheck altAttributesCheck;
		readonly MetaDescriptionCheck metaDescriptionCheck;

		/// <summary>
		/// Creates a new Html Analyser with the default checks
		/// </summary>
		public HtmlAnalyser()
			: this(new TitleCheck(StopWords.All), new HeadersCheck(), new AltAttributesCheck(), new MetaDescriptionCheck())
		{
		}

		/// <summary>
		/// Creates a new Html Analyser with the given checks
		/// </summary>
		/// <param name="titleCheck"></param>
		/// <param name="headersCheck"></param>
		/// <param name="altAttributesCheck"></param>
		/// <param name="metaDescriptionCheck"></param>
		public HtmlAnalyser(ITitleCheck titleCheck, IHeadersCheck headersCheck, IAltAttributesCheck altAttributesCheck, MetaDescriptionCheck metaDescriptionCheck)
		{
			this.titleCheck = titleCheck;
			this.headersCheck = headersCheck;
			this.altAttributesCheck = altAttributesCheck;
			this.metaDescriptionCheck = metaDescriptionCheck;
		}

		/// <summary>
		/// Analyses the given html document
		/// </summary>
		/// <param name="html">The HTML to analyse</param>
		/// <returns></returns>
		public HtmlAnalysisReport Analyse(string html)
		{
			if (string.IsNullOrEmpty(html))
				throw new ArgumentException("You must provide some HTML", "html");

			var htmlDocument = GetHtmlDocument(html);
			
			var titleAnalysis = this.titleCheck.Analyse(htmlDocument);
			var headersAnalysis = this.headersCheck.Analyse(htmlDocument);
			var altAttributesAnalysis = this.altAttributesCheck.Analyse(htmlDocument);
			var metaDescAnalysis = this.metaDescriptionCheck.Analyse(htmlDocument);

			return new HtmlAnalysisReport(titleAnalysis, headersAnalysis, altAttributesAnalysis, metaDescAnalysis);
		}

		static HtmlDocument GetHtmlDocument(string html)
		{
			try
			{
				var htmlDocument = new HtmlDocument();
				htmlDocument.LoadHtml(html);
				return htmlDocument;
			} 
			catch(Exception e)
			{
				throw new SeoAnlysisException("Unable to parse HTML document", e);
			}
		}
	}
}