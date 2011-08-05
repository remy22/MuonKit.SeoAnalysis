using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Anchors
{
	public class AnchorsCheck : IAnchorsCheck
	{
		public IEnumerable<AnchorAnalysis> Analyse(HtmlDocument document)
		{
			var anchors = document.DocumentNode.SelectNodes("//a") ?? new HtmlNodeCollection(document.DocumentNode);

			return anchors.Select(AnalyseAnchor);
		}

		static AnchorAnalysis AnalyseAnchor(HtmlNode anchor)
		{
			var href = anchor.GetAttributeValue("href", null);
			var rel = anchor.GetAttributeValue("rel", null);
			var title = anchor.GetAttributeValue("title", null);
			var text = anchor.InnerText;

			// todo: determine if its an offsite link?
			// determine if it contains a title, has text - if not, image? adivse

			return new AnchorAnalysis(text, title, href, rel);
		}
	}
}