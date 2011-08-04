using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Title
{
	public class TitleCheck : ITitleCheck
	{
		public TitleAnalysis Analyse(HtmlDocument document)
		{
			var titleNode = document.DocumentNode.SelectSingleNode("//title");
			if (titleNode == null)
				return new TitleAnalysis(null, WarningLevel.Critical, "The page does not have a title tag.");

			var titleText = titleNode.InnerText;
			if (string.IsNullOrEmpty(titleText) || titleText.Trim() == string.Empty)
				return new TitleAnalysis(string.Empty, WarningLevel.Critical, "The page contains an empty title tag.");

			if (titleText.Length < 10)
				return new TitleAnalysis(titleText, WarningLevel.Warning, "The page has a very short title. Ideally the title should be between 10 and 70 chars.");

			if (titleText.Length > 70)
				return new TitleAnalysis(titleText, WarningLevel.Warning, "The page has a very long title. Ideally the title should be between 10 and 70 chars.");

			return new TitleAnalysis(titleText, WarningLevel.Ok, "The page has a title tag of sensible length.");
		}
	}
}