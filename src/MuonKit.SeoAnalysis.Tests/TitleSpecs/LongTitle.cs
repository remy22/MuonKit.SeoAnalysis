using System.Linq;
using NUnit.Framework;

namespace MuonKit.SeoAnalysis.Tests.TitleSpecs
{
	public class LongTitle : BaseTest
	{
		protected override string Html
		{
			get { return @"<html><head><title>im am a very long title, i contain too many words and plenty of a an the stop words</title></head><body></body></html>"; }
		}

		[Test]
		public void ShouldBeWarning()
		{
			htmlAnalysisReport.Title.WarningLevel.Is(WarningLevel.Warning);
		}

		[Test]
		public void ShouldComplainAboutLength()
		{
			var enumerable = this.htmlAnalysisReport.Title.Messages.ToArray();
			enumerable[2].Text.ShouldEqual("The page has a very long title. Ideally the title should be between 10 and 70 chars.");
			enumerable[2].WarningLevel.ShouldEqual(WarningLevel.Warning);
		}

		[Test]
		public void ShouldComplainAboutWords()
		{
			var enumerable = this.htmlAnalysisReport.Title.Messages.ToArray();
			enumerable[1].Text.ShouldEqual("The title element contains a lot of words. Ideally it should contain between 3 and 9 words.");
			enumerable[1].WarningLevel.ShouldEqual(WarningLevel.Warning);
		}

		[Test]
		public void ShouldComplainAboutStopWords()
		{
			var enumerable = this.htmlAnalysisReport.Title.Messages.ToArray();
			enumerable[0].Text.ShouldEqual("The title element contains stop words which will be ignored by search engines.");
			enumerable[0].WarningLevel.ShouldEqual(WarningLevel.Advisory);
		}
	}
}