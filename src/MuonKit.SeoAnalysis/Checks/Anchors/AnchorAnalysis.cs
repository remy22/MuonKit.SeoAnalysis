namespace MuonKit.SeoAnalysis.Checks.Anchors
{
	public sealed class AnchorAnalysis
	{
		public readonly WarningLevel WarningLevel;
		public readonly string Message;

		public AnchorAnalysis(WarningLevel warningLevel, string message)
		{
			this.WarningLevel = warningLevel;
			this.Message = message;
		}
	}
}