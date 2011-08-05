namespace MuonKit.SeoAnalysis
{
	public static class WarningLevelExtensions
	{
		public static WarningLevel GetMostSevere(this WarningLevel level)
		{
			if ((level & WarningLevel.Critical) == WarningLevel.Critical)
				return WarningLevel.Critical;

			if ((level & WarningLevel.Warning) == WarningLevel.Warning)
				return WarningLevel.Warning;

			if ((level & WarningLevel.Advisory) == WarningLevel.Advisory)
				return WarningLevel.Advisory;

			return WarningLevel.Ok;
		}
	}
}