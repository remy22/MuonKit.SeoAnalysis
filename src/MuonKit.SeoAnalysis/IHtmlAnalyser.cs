namespace MuonKit.SeoAnalysis
{
	public interface IHtmlAnalyser
	{
		/// <summary>
		/// Analyses the given html document
		/// </summary>
		/// <param name="html">The HTML to analyse</param>
		/// <returns></returns>
		HtmlAnalysis Analyse(string html);
	}
}