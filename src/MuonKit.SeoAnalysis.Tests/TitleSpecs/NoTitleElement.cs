using System.Linq;
using NUnit.Framework;

namespace MuonKit.SeoAnalysis.Tests.TitleSpecs
{
	public class NoTitleElement : BaseTest
	{
		protected override string Html
		{
			get { return @"<html><head></head><body></body></html>"; }
		}

		[Test]
		public void ShouldBeCritical()
		{
			htmlAnalysisReport.Title.WarningLevel.Is(WarningLevel.Critical);
		}

		[Test]
		public void ShouldHaveAppropriateMessage()
		{
			htmlAnalysisReport.Title.Messages.Single().Text.ShouldEqual("The page does not have a title element.");
		}
	}
}