using System.Linq;
using NUnit.Framework;

namespace MuonKit.SeoAnalysis.Tests.AltAttributeSpecs
{
	public class MissingAttributes : BaseTest
	{
		protected override string Html
		{
			get { return @"<html><head><title>im short</title></head><body><img src=""/somepath"" /></body></html>"; }
		}

		[Test]
		public void ShouldComplain()
		{
			var enumerable = this.htmlAnalysisReport.AltAttributes.ToArray();
			enumerable[0].Message.ShouldEqual("Image with src `/somepath` has no alt attribute.");
			enumerable[0].WarningLevel.ShouldEqual(WarningLevel.Warning);
		}
	}
}