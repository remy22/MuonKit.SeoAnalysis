using System.Collections.Generic;
using System.Linq;

namespace MuonKit.SeoAnalysis.Checks
{
	public static class AnalysisExtensions
	{
		/// <summary>
		/// Gets the aggregated warning level for the collection of analyses </summary>
		/// <param name="analyses"></param>
		/// <returns></returns>
		public static WarningLevel WarningLevel(this IEnumerable<IAnalysis> analyses)
		{
			return analyses.Aggregate(SeoAnalysis.WarningLevel.Ok, (current, analysis) => current | analysis.WarningLevel);
		}
	}
}