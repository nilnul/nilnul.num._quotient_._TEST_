using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_;
using System;
using System.Numerics;

namespace nilnul.num._quotient_._TEST_.eg_.gtOne.co.lg
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			v(
				new DenomNonnil(3,2)
				,
				new DenomNonnil(5,4)
				,
				(0,1)

			);
			v(
				new DenomNonnil(3,2)
				,
				new DenomNonnil(3,2)
				,
				(1,1)
			);

			v(
				new DenomNonnil(3,2)
				,
				new DenomNonnil(2)
				,
				(1,2)
			);
			v(
				new DenomNonnil(3,2)
				,
				new DenomNonnil(9,4)
				,
				(2,2)
			);

			v(
				new DenomNonnil(3,2)
				,
				new DenomNonnil(10,4)
				,
				(2,3)
			);

			v(
				new DenomNonnil(3,2)
				,
				new DenomNonnil(27,8)
				,
				(3,3)
			);


			v(
				new DenomNonnil(3,2)
				,
				new DenomNonnil(80,16)
				,
				(3,4)
			);

			v(
				new DenomNonnil(3,2)
				,
				new DenomNonnil(81,16)
				,
				(4,4)
			);


		}
		void v(
			DenomNonnil a
			,
			DenomNonnil x
			,
			(BigInteger,BigInteger) expected
		) {
			var actual = nilnul.num.quotient_.gtOne.co._LgX._Lg_01gtOne(a, x);
			var isEq = actual == expected;

			Assert.IsTrue(
				
				isEq
			);
		}
	}
}
