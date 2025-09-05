using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.quotient.to_.radix_.dec
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var q = nilnul.num.quotient_.DenomNonnil.Parse("36674636328/78125");

			var q1 = nilnul.num.quotient_.DenomNonnil.Parse("470000");

			var dec1 = nilnul.num.quotient_.radix_.dec.of_.quotienty_._PerPrecisionX.ToDec(q1, 1000);

			var dec = nilnul.num.quotient_.radix_.dec.of_.quotienty_._PerPrecisionX.ToDec(q, 1000);


			Assert.IsTrue(
				nilnul.num.quotient.re_.approx_.ratio_.Hundredth.Singleton.re(
				dec1.toDenomNonnil(), dec.toDenomNonnil()
				)
			);



		}
	}
}
