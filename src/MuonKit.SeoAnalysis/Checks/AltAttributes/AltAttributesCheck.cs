using System.Text;
using HtmlAgilityPack;
namespace MuonKit.SeoAnalysis.Checks.AltAttributes
{
	public class AltAttributesCheck : IAltAttributesCheck
	{
		public AltAttributesAnalysis Analyse(HtmlDocument document)
		{
			var images = document.DocumentNode.SelectNodes("//img") ?? new HtmlNodeCollection(document.DocumentNode);

			var warningLevel = WarningLevel.Ok;
			var message = new StringBuilder();

			foreach (var image in images)
			{
				var altAttr = image.Attributes["alt"];

				if(altAttr == null)
				{
					warningLevel |= WarningLevel.Advisory;
					message
						.Append("Image with source: `")
						.Append(image.Attributes["src"].Value)
						.AppendLine("` has no alt attribute.");

				} else if(altAttr.Value != null && !string.IsNullOrEmpty(altAttr.Value.Trim()))
				{
					warningLevel |= WarningLevel.Advisory;
					message
						.Append("Image with source: `")
						.Append(image.Attributes["src"].Value)
						.AppendLine("` has an empty alt attribute.");
				}
			}

			if (message.Length == 0)
				message.Append("All img tags have non-empty alt attributes.");

			return new AltAttributesAnalysis(warningLevel, message.ToString());
		}
	}
}