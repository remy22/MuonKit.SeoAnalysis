using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.MetaDescription
{
	public interface IMetaDescriptionCheck
	{
		MetaDescriptionAnalysis Analyse(HtmlDocument document);
	}
}