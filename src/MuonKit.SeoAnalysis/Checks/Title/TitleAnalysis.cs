namespace MuonKit.SeoAnalysis.Checks.Title
{
	public sealed class TitleAnalysis
	{
		public readonly string Title;

		public readonly WarningLevel WarningLevel;
		public readonly string Message;

		public TitleAnalysis(string title, WarningLevel warningLevel, string message)
		{
			this.Title = title;
			this.WarningLevel = warningLevel;
			this.Message = message;
		}
	}
}