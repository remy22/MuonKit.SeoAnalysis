using System.Collections.Generic;
using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.AltAttributes
{
	public interface IAltAttributesCheck
	{
		IEnumerable<AltAttributeAnalysis> Analyse(HtmlDocument document);
	}
}