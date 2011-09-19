using NUnit.Framework;

namespace MuonKit.SeoAnalysis.Tests
{
	public static class Extensions
	{
		public static void ShouldEqual<T>(this T self, T expected)
		{
			Assert.AreEqual(expected, self);
		}

		public static void Is(this WarningLevel self, WarningLevel expected)
		{
			Assert.IsTrue((self & expected) == expected);
		}
	}
}