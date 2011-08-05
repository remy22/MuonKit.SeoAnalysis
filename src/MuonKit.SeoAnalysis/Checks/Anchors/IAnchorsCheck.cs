using System.Collections.Generic;
using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Anchors
{
	public interface IAnchorsCheck
	{
		IEnumerable<AnchorAnalysis> Analyse(HtmlDocument document);
	}
}