using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
namespace MuonKit.SeoAnalysis.Checks.AltAttributes
{
	public class AltAttributesCheck : IAltAttributesCheck
	{
		public IEnumerable<AltAttributeAnalysis> Analyse(HtmlDocument document)
		{
			var images = document.DocumentNode.SelectNodes("//img") ?? new HtmlNodeCollection(document.DocumentNode);
			return images.Select(AnalyseImage);
		}

		static AltAttributeAnalysis AnalyseImage(HtmlNode image)
		{
			var altAttr = image.Attributes["alt"];

			if (altAttr == null)
				return new AltAttributeAnalysis(WarningLevel.Warning, "Image with src `" + image.Attributes["src"].Value + "` has no alt attribute.");

			if (altAttr.Value == null || string.IsNullOrEmpty(altAttr.Value.Trim()))
				return new AltAttributeAnalysis(WarningLevel.Warning, "Image with src `" + image.Attributes["src"].Value + "` has an empty alt attribute.");

			return new AltAttributeAnalysis(WarningLevel.Ok, "Image with src `" + image.Attributes["src"].Value + "` has a non empty alt attribute.");
		}
	}
}