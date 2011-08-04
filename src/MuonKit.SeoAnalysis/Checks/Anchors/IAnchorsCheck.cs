using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Anchors
{
	public interface IAnchorsCheck
	{
		AnchorAnalysis Analyse(HtmlDocument document);
	}
}