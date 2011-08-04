namespace MuonKit.SeoAnalysis.Checks.Headers
{
	public sealed class HeadersAnalysis
	{
		public readonly HeaderAnalysis H1s;
		public readonly HeaderAnalysis H2s;
		public readonly HeaderAnalysis H3s;
		public readonly HeaderAnalysis H4s;
		public readonly HeaderAnalysis H5s;
		public readonly HeaderAnalysis H6s;

		public HeadersAnalysis(HeaderAnalysis h1S, HeaderAnalysis h2S, HeaderAnalysis h3S, HeaderAnalysis h4S, HeaderAnalysis h5S, HeaderAnalysis h6S)
		{
			this.H1s = h1S;
			this.H2s = h2S;
			this.H3s = h3S;
			this.H4s = h4S;
			this.H5s = h5S;
			this.H6s = h6S;
		}

		public WarningLevel WarningLevel { get { return H1s.WarningLevel | H2s.WarningLevel | H3s.WarningLevel | H4s.WarningLevel | H5s.WarningLevel | H6s.WarningLevel; }}
	}
}