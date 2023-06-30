using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Numerics;

namespace nilnul.num._quotient_._TEST_.eg_.fractile_.nonneg.of_.ofDividing_.byEuclid
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var r = nilnul.num.integer.str_.started_.nonhead8positive.fractile_.nonneg.of_.ofQuotient_._ByEuclidAlgorithmX._AsAdders_01nonneg(43,19).ToArray();

			Assert.IsTrue(
				//nilnul.num.integer.str.eq
				nilnul.obj.str.Eq<BigInteger>.Singleton.Equals(
					r,
					new BigInteger[] {
						2,3,1,4
					}
				)
			);
		}
	}
}
