using System;
using System.Collections.Generic;
using HtmlAgilityPack;

namespace MuonKit.SeoAnalysis.Checks.MetaDescription
{
	public class MetaDescriptionCheck : IMetaDescriptionCheck
	{
		// compare to first para of body?
		public MetaDescriptionAnalysis Analyse(HtmlDocument document)
		{
			var nodes = document.DocumentNode.SelectNodes("head/meta[@name=description]") ?? new HtmlNodeCollection(document.DocumentNode);

			if (nodes.Count == 0)
				return new MetaDescriptionAnalysis(null, new Message(WarningLevel.Critical, "The page does not contain a meta description element."));

			if(nodes.Count > 1)
				return new MetaDescriptionAnalysis(null, new Message(WarningLevel.Critical, "The page contains multiple meta description elements. This is not recommended."));

			var desc = nodes[0].GetAttributeValue("content", null);

			if(desc == null || desc.Trim() == string.Empty)
				return new MetaDescriptionAnalysis(null, new Message(WarningLevel.Critical, "The page contains a meta description element, but it contains no content."));

			var messages = new List<Message>();

			if(desc.Length < 100)
				messages.Add(new Message(WarningLevel.Warning, "The meta description contains less than 100 characters. It is recommended to provide between 160 and 180."));

			if (desc.Length >=100 && desc.Length < 160)
				messages.Add(new Message(WarningLevel.Advisory, "The meta description contains less than 160 characters. It is recommended to provide between 160 and 180."));

			if (desc.Length > 180 && desc.Length < 220)
				messages.Add(new Message(WarningLevel.Advisory, "The meta description contains more than 180 characters. It is recommended to provide between 160 and 180."));

			if (desc.Length >= 220)
				messages.Add(new Message(WarningLevel.Warning, "The meta description contains more than 180 characters. It is recommended to provide between 160 and 180."));

			var words = desc.Split(' ');

			if (words.Length < 20)
				messages.Add(new Message(WarningLevel.Critical, "The meta description contains less than 20 words. It is recommended to provide between 20 and 30."));

			if (words.Length > 30)
				messages.Add(new Message(WarningLevel.Critical, "The meta description contains more than 30 words. It is recommended to provide between 20 and 30."));

			return new MetaDescriptionAnalysis(desc, messages);
		}
	}
}