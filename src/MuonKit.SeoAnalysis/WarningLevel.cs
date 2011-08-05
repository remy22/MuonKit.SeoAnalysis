using System;

namespace MuonKit.SeoAnalysis
{
	/// <summary>
	/// Enum representing the severity of an analysis. Operates as flags to allow aggregation
	/// </summary>
	[Flags]
	public enum WarningLevel
	{
		Ok = 0,
		Advisory = 1,
		Warning = 2,
		Critical = 4
	}
}