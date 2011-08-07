namespace MuonKit.SeoAnalysis.Checks.AltAttributes
{
	public sealed class AltAttributeAnalysis : IAnalysis
	{
		/// <summary>
		/// The warning level for this image's alt attribte
		/// </summary>
		public WarningLevel WarningLevel { get; private set; }

		/// <summary>
		/// The message for this image's alt attribute analysis
		/// </summary>
		public readonly string Message;

		public AltAttributeAnalysis(WarningLevel warningLevel, string message)
		{
			this.WarningLevel = warningLevel;
			this.Message = message;
		}
	}
}