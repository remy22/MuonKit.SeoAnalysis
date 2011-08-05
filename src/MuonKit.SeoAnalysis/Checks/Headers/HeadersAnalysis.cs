namespace MuonKit.SeoAnalysis.Checks.Headers
{
	public sealed class HeadersAnalysis : IAnalysis
	{
		public readonly HeaderTypeAnalysis H1s;
		public readonly HeaderTypeAnalysis H2s;
		public readonly HeaderTypeAnalysis H3s;
		public readonly HeaderTypeAnalysis H4s;
		public readonly HeaderTypeAnalysis H5s;
		public readonly HeaderTypeAnalysis H6s;

		public HeadersAnalysis(HeaderTypeAnalysis h1S, HeaderTypeAnalysis h2S, HeaderTypeAnalysis h3S, HeaderTypeAnalysis h4S, HeaderTypeAnalysis h5S, HeaderTypeAnalysis h6S)
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