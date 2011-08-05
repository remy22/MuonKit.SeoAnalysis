namespace MuonKit.SeoAnalysis.Checks
{
	public class Message : IAnalysis
	{
		public WarningLevel WarningLevel { get; private set; }
		public readonly string Text;

		public Message(WarningLevel warningLevel, string text)
		{
			this.WarningLevel = warningLevel;
			this.Text = text;
		}
	}
}