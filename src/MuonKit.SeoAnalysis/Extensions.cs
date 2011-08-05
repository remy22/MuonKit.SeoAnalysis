using System.Collections.Generic;
using System.Linq;

namespace MuonKit.SeoAnalysis
{
	public static class Extensions
	{
		/// <summary>
		/// Gets the most severe level from the given warning levels
		/// </summary>
		/// <param name="levels"></param>
		/// <returns></returns>
		public static WarningLevel GetMostSevere(this WarningLevel levels)
		{
			if ((levels & SeoAnalysis.WarningLevel.Critical) == SeoAnalysis.WarningLevel.Critical)
				return SeoAnalysis.WarningLevel.Critical;

			if ((levels & SeoAnalysis.WarningLevel.Warning) == SeoAnalysis.WarningLevel.Warning)
				return SeoAnalysis.WarningLevel.Warning;

			if ((levels & SeoAnalysis.WarningLevel.Advisory) == SeoAnalysis.WarningLevel.Advisory)
				return SeoAnalysis.WarningLevel.Advisory;

			return SeoAnalysis.WarningLevel.Ok;
		}

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