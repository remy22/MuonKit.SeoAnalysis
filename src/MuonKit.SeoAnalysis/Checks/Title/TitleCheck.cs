using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Title
{
	public class TitleCheck : ITitleCheck
	{
		readonly IEnumerable<string> stopWords;

		public TitleCheck() : this(StopWords.All)
		{
		}

		public TitleCheck(IEnumerable<string> stopWords)
		{
			this.stopWords = stopWords;
		}

		public TitleAnalysis Analyse(HtmlDocument document)
		{
			// TODO: check for multiple tags
			var titleNode = document.DocumentNode.SelectSingleNode("//title");
			if (titleNode == null)
				return new TitleAnalysis(null, new Message(WarningLevel.Critical, "The page does not have a title tag."));

			var titleText = titleNode.InnerText;
			if (string.IsNullOrEmpty(titleText) || titleText.Trim() == string.Empty)
				return new TitleAnalysis(string.Empty, new Message(WarningLevel.Critical, "The page contains an empty title tag."));

			var messages = new List<Message>();

			var words = titleText.Split(' ');

			// stop words
			var titleStopWords = words.Intersect(this.stopWords, new CaseInsensitiveStringEqualityComparer());
			if (titleStopWords.Any())
				messages.Add(new Message(WarningLevel.Advisory, "The title element contains stop words which will be ignored by search engines."));

			// word count
			if(words.Length < 3)
				messages.Add(new Message(WarningLevel.Warning, "The title element contains very few words. Ideally it should contain between 3 and 9 words."));

			if (words.Length > 9)
				messages.Add(new Message(WarningLevel.Warning, "The title element contains a lot of words. Ideally it should contain between 3 and 9 words."));

			if (titleText.Length < 10)
			{
				messages.Add(new Message(WarningLevel.Warning, "The page has a very short title. Ideally the title should be between 10 and 70 chars."));
				return new TitleAnalysis(titleText, messages);
			}

			if (titleText.Length > 70)
			{
				messages.Add(new Message(WarningLevel.Warning, "The page has a very long title. Ideally the title should be between 10 and 70 chars."));
				return new TitleAnalysis(titleText, messages);
			}

			if(messages.Count > 0)
				return new TitleAnalysis(titleText, messages);

			return new TitleAnalysis(titleText, new Message(WarningLevel.Ok, "The page has a title tag of sensible length."));
		}
	}
}