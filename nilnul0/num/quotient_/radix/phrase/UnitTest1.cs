using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix.phrase
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var r = new nilnul.num.quotient_.radix_.ByNeg(
				new nilnul.num.quotient_.nonneg_.Radix(
					10
					,
					new BigInteger[] { }
					,
					0
				)
				,
				false
			);

			v(r, "0*10^0");


			 r = new nilnul.num.quotient_.radix_.ByNeg(
				new nilnul.num.quotient_.nonneg_.Radix(
					10
					,
					new BigInteger[] { }
					,
					0
				)
				,
				true
			);

			v(r, "-0*10^0");



			 r = new nilnul.num.quotient_.radix_.ByNeg(
				new nilnul.num.quotient_.nonneg_.Radix(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-2
				)
				,
				true
			);

			v(r, "-321*10^-2");

			 r = new nilnul.num.quotient_.radix_.ByNeg(
				new nilnul.num.quotient_.nonneg_.Radix(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-3
				)
				,
				true
			);

			v(r, "-321*10^-3");

			 r = new nilnul.num.quotient_.radix_.ByNeg(
				new nilnul.num.quotient_.nonneg_.Radix(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-4
				)
				,
				false
			);

			v(r, "321*10^-4");

			 r = new nilnul.num.quotient_.radix_.ByNeg(
				new nilnul.num.quotient_.nonneg_.Radix(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					4
				)
				,
				false
			);

			v(r, "321*10^4");


		}

		void v(object x, string expected) {
			string v = x.ToString();
			Assert.IsTrue(
				v == expected
			);
		}


	}
}
