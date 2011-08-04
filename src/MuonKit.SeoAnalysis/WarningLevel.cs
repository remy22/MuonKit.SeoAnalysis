using System;

namespace MuonKit.SeoAnalysis
{
	[Flags]
	public enum WarningLevel
	{
		Ok = 0,
		Advisory = 1,
		Warning = 2,
		Critical = 4
	}
}