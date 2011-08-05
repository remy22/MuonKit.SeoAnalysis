namespace MuonKit.SeoAnalysis
{
	public interface IAnalysis
	{
		/// <summary>
		/// The (potentially aggregated) analysis warning level
		/// </summary>
		WarningLevel WarningLevel { get; }
	}
}