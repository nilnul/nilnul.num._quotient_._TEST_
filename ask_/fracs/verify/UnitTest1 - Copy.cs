using System;
using System.Diagnostics;
using System.Numerics;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q = nilnul.num._quotient.Dividing;

namespace nilnul.num._quotient_._TEST_.ask_.fracs
{
	[TestClass]
	public class UnitTest11
	{
		[TestMethod]
		public void TestMethod1()
		{
			string clean(string s) {
				return Regex.Replace(s, " |\r|\n|\t|_", "");
				return s.Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("_","").Replace("\t","");
			}

			BigInteger a = BigInteger.Parse(
				clean(
				@"1544_7680_2108 7461  6644 1951 3150 1991 9837 4856
					6432 5669 5654 3170 0026 6348 9825 3202 0352 7799 9"
				)
			);

			BigInteger b = BigInteger.Parse(
				clean(
				@"
					3687 5131 7941 2999 9827 1978 1156 5225 4748 2549 2979 9689 7197 0996 2831 3747 1637 2246 3405 5579
				"
				)
			);

			BigInteger c = BigInteger.Parse(
				clean(
				@"
					4373 6126 7792 8697 2578 6125 2602 3713 9015 2816 5375 5816 1613 6186 2143 7993 3784 2346 7772 036
				"
				)
			);
			Debug.Assert(
				new Q(a, b + c)
					+
				new Q(b, c + a)
					+
				new Q(c, a + b) == 4
			);
		}
	}
}