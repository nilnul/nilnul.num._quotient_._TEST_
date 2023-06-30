using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_;
using System;
using System.Numerics;

namespace nilnul.num._quotient_._TEST_.eg_.positive_.nonone.duo_.positive.lg
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(1)
				,
				(0, 0)

			);
			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(5, 4)
				,
				(0, 1)

			);

			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(3, 2)
				,
				(1, 1)
			);

			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(2)
				,
				(1, 2)
			);
			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(9, 4)
				,
				(2, 2)
			);

			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(10, 4)
				,
				(2, 3)
			);

			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(27, 8)
				,
				(3, 3)
			);


			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(80, 16)
				,
				(3, 4)
			);

			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(81, 16)
				,
				(4, 4)
			);


			#region gt1, lt1


			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(4, 5)
				,
				(-1, 0)

			);
			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(2, 3)
				,
				(-1, -1)
			);

			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(1, 2)
				,
				(-2, -1)
			);
			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(4, 9)
				,
				(-2, -2)
			);

			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(4, 10)
				, (-3, -2)
			);

			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(8, 27), (-3, -3)
			);


			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(16, 80), (-4, -3)
			);

			v(
				new DenomNonnil(3, 2)
				,
				new DenomNonnil(16, 81)
				,
				(-4, -4)
			);

			#endregion

			#region lt1, lt1

			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(1)
				,
				(0, 0)

			);


			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(4, 5)
				,
				(0, 1)

			);

			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(2, 3)
				,
				(1, 1)
			);

			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(1, 2)
				,
				(1, 2)
			);
			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(4, 9)
				,
				(2, 2)
			);

			v(new DenomNonnil(2, 3), new DenomNonnil(4, 10), (2, 3));

			v(new DenomNonnil(2, 3), new DenomNonnil(8, 27), (3, 3));


			v(new DenomNonnil(2, 3), new DenomNonnil(16, 80), (3, 4));

			v(new DenomNonnil(2, 3), new DenomNonnil(16, 81), (4, 4));
			#endregion


			lt1_gt1();

		}

		public void lt1_gt1()
		{
			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(5, 4)
				,
				(-1, 0)

			);
			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(3, 2)
				,
				(-1, -1)
			);

			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(2)
				,
				(-2, -1)
			);
			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(9, 4)
				,
				(-2, -2)
			);

			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(10, 4)
				,
				(-3, -2)
			);

			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(27, 8)
				,
				(-3, -3)
			);


			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(80, 16)
				,
				(-4, -3)
			);

			v(
				new DenomNonnil(2, 3)
				,
				new DenomNonnil(81, 16)
				,
				(-4, -4)
			);





		}

		void v(
			DenomNonnil a
			,
			DenomNonnil x
			,
			(BigInteger, BigInteger) expected
		)
		{
			var actual = nilnul.num.quotient_.positive_.nonone.duo_.positive._LgX._Lg_0positiveNonone_1positive(a, x);
			var isEq = actual == expected;

			Assert.IsTrue(

				isEq
			);
		}
	}
}
