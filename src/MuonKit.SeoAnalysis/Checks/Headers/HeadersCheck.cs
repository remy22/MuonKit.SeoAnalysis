using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Headers
{
	public class HeadersCheck : IHeadersCheck
	{
		readonly IEnumerable<string> stopWords;

		public HeadersCheck() : this(StopWords.All)
		{
		}

		public HeadersCheck(IEnumerable<string> stopWords)
		{
			this.stopWords = stopWords;
		}

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

		static HeaderTypeAnalysis AnalyseH1s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h1") ?? new HtmlNodeCollection(document.DocumentNode);

			var headerAnalyses = headers.Select(header => AnalyseH1(header.InnerText));

			if (headers.Count == 0)
				return new HeaderTypeAnalysis(headerAnalyses, new Message(WarningLevel.Warning, "The page has no H1 tag."));

			if (headers.Count > 1)
				return new HeaderTypeAnalysis(headerAnalyses, new Message(WarningLevel.Warning, "The page has " + headers.Count + " H1 tags. It is suggested to have only one H1 tag per page."));

			return new HeaderTypeAnalysis(headerAnalyses, new Message(WarningLevel.Ok, "The page has a single H1 tag."));
		}

		static HeaderAnalysis AnalyseH1(string header)
		{
			// TODO check length, stop wordsm keyword density
			return new HeaderAnalysis(header, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}


		static HeaderTypeAnalysis AnalyseH2s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h2") ?? new HtmlNodeCollection(document.DocumentNode);

			var headerAnalyses = headers.Select(header => AnalyseH2(header.InnerText));

			return new HeaderTypeAnalysis(headerAnalyses, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}
		static HeaderAnalysis AnalyseH2(string header)
		{
			// TODO check length, stop wordsm keyword density
			return new HeaderAnalysis(header, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}

		static HeaderTypeAnalysis AnalyseH3s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h3") ?? new HtmlNodeCollection(document.DocumentNode);

			var headerAnalyses = headers.Select(header => AnalyseH3(header.InnerText));

			return new HeaderTypeAnalysis(headerAnalyses, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}
		static HeaderAnalysis AnalyseH3(string header)
		{
			// TODO check length, stop wordsm keyword density
			return new HeaderAnalysis(header, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}
		static HeaderTypeAnalysis AnalyseH4s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h4") ?? new HtmlNodeCollection(document.DocumentNode);

			var headerAnalyses = headers.Select(header => AnalyseH4(header.InnerText));

			return new HeaderTypeAnalysis(headerAnalyses, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}
		static HeaderAnalysis AnalyseH4(string header)
		{
			// TODO check length, stop wordsm keyword density
			return new HeaderAnalysis(header, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}
		static HeaderTypeAnalysis AnalyseH5s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h5") ?? new HtmlNodeCollection(document.DocumentNode);

			var headerAnalyses = headers.Select(header => AnalyseH5(header.InnerText));

			return new HeaderTypeAnalysis(headerAnalyses, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}
		static HeaderAnalysis AnalyseH5(string header)
		{
			// TODO check length, stop wordsm keyword density
			return new HeaderAnalysis(header, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}
		static HeaderTypeAnalysis AnalyseH6s(HtmlDocument document)
		{
			var headers = document.DocumentNode.SelectNodes("//h6") ?? new HtmlNodeCollection(document.DocumentNode);

			var headerAnalyses = headers.Select(header => AnalyseH6(header.InnerText));

			return new HeaderTypeAnalysis(headerAnalyses, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}
		static HeaderAnalysis AnalyseH6(string header)
		{
			// TODO check length, stop wordsm keyword density
			return new HeaderAnalysis(header, new Message(WarningLevel.Ok, "NOT IMPLEMENTED"));
		}
	}
}