using System;
using System.Runtime.Serialization;

namespace MuonKit.SeoAnalysis
{
	public class SeoAnlysisException : Exception
	{
		public SeoAnlysisException(string message) : base(message)
		{
		}

		public SeoAnlysisException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected SeoAnlysisException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}