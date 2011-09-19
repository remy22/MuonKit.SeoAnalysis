using System.Linq;
using NUnit.Framework;

namespace MuonKit.SeoAnalysis.Tests.MetaDescription
{
	public class MissingElement : BaseTest
	{
		protected override string Html
		{
			get { return @"<html><head></head><body></body></html>"; }
		}

		[Test]
		public void ShouldComplain()
		{
			var enumerable = this.htmlAnalysisReport.MetaDescAnalysis.Messages.ToArray();
			enumerable[0].Text.ShouldEqual("The <head> does not contain a meta description element.");
			enumerable[0].WarningLevel.ShouldEqual(WarningLevel.Critical);
		}
	}
}