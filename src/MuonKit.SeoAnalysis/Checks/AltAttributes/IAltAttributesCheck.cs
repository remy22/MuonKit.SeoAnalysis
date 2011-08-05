using System.Collections.Generic;
using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.AltAttributes
{
	public interface IAltAttributesCheck
	{
		IEnumerable<AltAttributesAnalysis> Analyse(HtmlDocument document);
	}
}