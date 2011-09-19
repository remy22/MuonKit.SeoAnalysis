using NUnit.Framework;

namespace MuonKit.SeoAnalysis.Tests
{
	[TestFixture]
	public abstract class BaseTest
	{
		HtmlAnalyser htmlAnalyser;
		protected HtmlAnalysisReport htmlAnalysisReport;

		[SetUp]
		public void SetUp()
		{
			this.htmlAnalyser = new HtmlAnalyser();
			this.htmlAnalysisReport = this.htmlAnalyser.Analyse(this.Html);
		}

		protected abstract string Html { get; }
	}
}
