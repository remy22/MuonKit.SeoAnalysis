using System.Collections.Generic;

namespace MuonKit.SeoAnalysis
{
	/// <summary>
	/// Equates strings regardless of case (culture invariant)
	/// </summary>
	public class CaseInsensitiveStringEqualityComparer : IEqualityComparer<string>
	{
		public bool Equals(string x, string y)
		{
			if (x == null && y == null)
				return true;
			if (x == null || y == null)
				return false;

			return x.ToUpperInvariant() == y.ToUpperInvariant();
		}

		public int GetHashCode(string obj)
		{
			return obj == null ? 0 : obj.ToUpperInvariant().GetHashCode();
		}
	}
}