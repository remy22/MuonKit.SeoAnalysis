using System.Linq;
using NUnit.Framework;

namespace MuonKit.SeoAnalysis.Tests.MetaDescription
{
	public class EmptyElement : BaseTest
	{
		protected override string Html
		{
			get { return @"<html><head><meta name=""description"" /></head><body></body></html>"; }
		}

		[Test]
		public void ShouldComplain()
		{
			var enumerable = this.htmlAnalysisReport.MetaDescAnalysis.Messages.ToArray();
			enumerable[0].Text.ShouldEqual("The <head> contains a meta description element, but it contains no content.");
			enumerable[0].WarningLevel.ShouldEqual(WarningLevel.Critical);
		}
	}
}