namespace MuonKit.SeoAnalysis.Checks.AltAttributes
{
	public sealed class AltAttributesAnalysis
	{
		public readonly WarningLevel WarningLevel;
		public readonly string Message;

		public AltAttributesAnalysis(WarningLevel warningLevel, string message)
		{
			this.WarningLevel = warningLevel;
			this.Message = message;
		}
	}
}