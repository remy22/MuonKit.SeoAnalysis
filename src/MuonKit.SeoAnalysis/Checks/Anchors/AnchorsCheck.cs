using System;
using System.Text;
using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.Anchors
{
	public class AnchorsCheck : IAnchorsCheck
	{
		public AnchorAnalysis Analyse(HtmlDocument document)
		{
			var images = document.DocumentNode.SelectNodes("//a") ?? new HtmlNodeCollection(document.DocumentNode);

			var warningLevel = WarningLevel.Ok;
			var message = new StringBuilder();

			throw new NotImplementedException();

			foreach (var image in images)
			{
				
			}

			return new AnchorAnalysis(warningLevel, message.ToString());
		}
	}
}