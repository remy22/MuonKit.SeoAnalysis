using System;
using System.Linq;
using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Headers
{
	public class HeadersCheck : IHeadersCheck
	{
		public HeadersAnalysis Analyse(HtmlDocument document)
		{
			var h1 = AnalyseH1s(document);
			var h2 = AnalyseH2s(document);
			var h3 = AnalyseH3s(document);
			var h4 = AnalyseH4s(document);
			var h5 = AnalyseH5s(document);
			var h6 = AnalyseH6s(document);

			return new HeadersAnalysis(h1, h2, h3, h4, h5, h6);
		}

		static HeaderAnalysis AnalyseH1s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h1") ?? new HtmlNodeCollection(document.DocumentNode);

			if (headers.Count == 0)
				return new HeaderAnalysis(headers.Select(t => t.InnerText), WarningLevel.Warning, "The page has no H1 tag.");

			if (headers.Count > 1)
				return new HeaderAnalysis(headers.Select(t => t.InnerText), WarningLevel.Warning, "The page has " + headers.Count + " H1 tags. It is suggested to have only one H1 tag per page.");

			// TODO examine length

			return new HeaderAnalysis(headers.Select(t => t.InnerText), WarningLevel.Ok, "The page has a single H1 tag.");
		}

		static HeaderAnalysis AnalyseH2s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h2") ?? new HtmlNodeCollection(document.DocumentNode);

			throw new NotImplementedException();

			return new HeaderAnalysis(headers.Select(t => t.InnerText), WarningLevel.Ok, null);
		}

		static HeaderAnalysis AnalyseH3s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h3") ?? new HtmlNodeCollection(document.DocumentNode);

			throw new NotImplementedException();

			return new HeaderAnalysis(headers.Select(t => t.InnerText), WarningLevel.Ok, null);
		}

		static HeaderAnalysis AnalyseH4s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h4") ?? new HtmlNodeCollection(document.DocumentNode);

			throw new NotImplementedException();

			return new HeaderAnalysis(headers.Select(t => t.InnerText), WarningLevel.Ok, null);
		}

		static HeaderAnalysis AnalyseH5s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h5") ?? new HtmlNodeCollection(document.DocumentNode);

			throw new NotImplementedException();

			return new HeaderAnalysis(headers.Select(t => t.InnerText), WarningLevel.Ok, null);
		}

		static HeaderAnalysis AnalyseH6s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h6") ?? new HtmlNodeCollection(document.DocumentNode);

			throw new NotImplementedException();

			return new HeaderAnalysis(headers.Select(t => t.InnerText), WarningLevel.Ok, null);
		}
	}
}