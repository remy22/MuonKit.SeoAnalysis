using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.AltAttributes
{
	public interface IAltAttributesCheck
	{
		AltAttributesAnalysis Analyse(HtmlDocument document);
	}
}