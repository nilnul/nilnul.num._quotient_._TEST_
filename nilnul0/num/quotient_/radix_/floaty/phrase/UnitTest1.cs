using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;
using R = nilnul.num.quotient_.nonneg_.radix_.Floaty;
using F = nilnul.num.quotient_.radix_.Floaty;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix_.floaty.phrase
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var r = new nilnul.num.quotient_.radix_.Floaty(
				new nilnul.num.quotient_.nonneg_.radix_.Floaty(
					10
					,
					new BigInteger[] { }
					,
					0
				)
				,
				false
			);

			v(r, "0");


			 r = new nilnul.num.quotient_.radix_.Floaty(
				new nilnul.num.quotient_.nonneg_.radix_.Floaty(
					10
					,
					new BigInteger[] { }
					,
					0
				)
				,
				true
			);

			v(r, "-0");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-2
				)
				,
				false
			);

			v(r, "3.21");


			 r = new nilnul.num.quotient_.radix_.Floaty(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-2
				)
				,
				true
			);

			v(r, "-3.21");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-3
				)
				,
				false
			);

			v(r, ".321");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-3
				)
				,
				true
			);

			v(r, "-.321");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					0
				)
				,
				false
			);

			v(r, "321");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					0
				)
				,
				true
			);

			v(r, "-321");




		}

		void v(F x, string expected) {
			Assert.IsTrue(
				x.ToString() == expected
			);
		}


	}
}
