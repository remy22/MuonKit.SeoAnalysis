namespace MuonKit.SeoAnalysis.Checks.AltAttributes
{
	public sealed class AltAttributesAnalysis : IAnalysis
	{
		public WarningLevel WarningLevel { get; private set; }
		public readonly string Message;

		public AltAttributesAnalysis(WarningLevel warningLevel, string message)
		{
			this.WarningLevel = warningLevel;
			this.Message = message;
		}
	}
}