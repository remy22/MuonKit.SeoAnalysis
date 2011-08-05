using System.Collections.Generic;

namespace MuonKit.SeoAnalysis
{
	/// <summary>
	/// Class containing common search engine stop words
	/// </summary>
	public static class StopWords
	{
		// TODO: Implement fully
		public static readonly IEnumerable<string> All = new[]
		                                                 	{
		                                                 		"a",
																"an",
																"and"
		                                                 	};
	}
}