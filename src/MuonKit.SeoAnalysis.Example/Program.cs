using System;
using System.IO;

namespace MuonKit.SeoAnalysis.Example
{
	class Program
	{
		static void Main(string[] args)
		{
//			var path = args[0];
//
//			TextReader reader = new StreamReader(path);
//			var document = reader.ReadToEnd();

			var path = "direct input";
			var document = @"
<html><head><title>a title</title></head><body></body></html>
";

			var htmlAnalyser = new HtmlAnalyser();

			var htmlAnalysis = htmlAnalyser.Analyse(document);

			Console.WriteLine("Analysis of " + path);
			Console.WriteLine("=========================================");

			Console.WriteLine("Title:");
			Console.WriteLine("-----------------------");
			Console.Write("Title text: ");
			Console.WriteLine(htmlAnalysis.Title.Title);
			Console.Write("Warning level: ");
			Console.WriteLine(htmlAnalysis.Title.WarningLevel.GetMostSevere());

			foreach(var message in htmlAnalysis.Title.Messages)
			{
				Console.Write("--> ");
				Console.Write(message.Text);
				Console.Write(" (");
				Console.Write(message.WarningLevel.GetMostSevere());
				Console.WriteLine(")");
			}

			Console.ReadKey();
		}
	}
}
