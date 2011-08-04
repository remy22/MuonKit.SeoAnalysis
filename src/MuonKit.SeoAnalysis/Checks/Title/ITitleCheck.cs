using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Title
{
	/// <summary>
	/// Checks the Title tag
	/// </summary>
	public interface ITitleCheck
	{
		TitleAnalysis Analyse(HtmlDocument document);
	}
}