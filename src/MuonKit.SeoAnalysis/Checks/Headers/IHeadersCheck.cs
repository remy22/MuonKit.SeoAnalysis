using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Headers
{
	public interface IHeadersCheck
	{
		HeadersAnalysis Analyse(HtmlDocument document);
	}
}