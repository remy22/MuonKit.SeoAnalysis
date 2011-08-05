using System.Collections.Generic;

namespace MuonKit.SeoAnalysis
{
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
			if(obj == null)
				return 0;

			return obj.ToUpperInvariant().GetHashCode();
		}
	}
}