using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_;
using System;
using System.Collections;
using System.Collections.Generic;

namespace nilnul.num._quotient_._TEST_.eg_.fractile.to_.quotiently_.cascadely
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			v(
				new[] { -3 }, -3
			);
			v(
				new[] { -2 }, -2
			);

			v(
				new[] { -1 }, -1
			);

			v(
				new[] { 0 }, 0
			);
			v(
				new[] { 1 }, 1
			);
			v(
				new[] { 2 }, 2
			);
			v(
				new[] { 3 }, 3
			);



			v(
				new[] { -1,1 },0
			);

			v(
				new[] {-1,3 }, -2,3
			);

			v(
				new[] { -1,2 },-1,2
			);


			v(
				new[] { 0,1 }, 1
			);

			v(
				new[] { 0,2 }, 1,2
			);
			v(
				new[] { 0,3 }, 1,3
			);


			v(
				new[] { 1,1 },2
			);

			v(
				new[] { 1,2 }, 3,2
			);
			v(
				new[] { 1,3 }, 4,3
			);


			v(
				new[] { 2,1 },3
			);

			v(
				new[] { 2,2 }, 5,2
			);
			v(
				new[] { 2,3 }, 7,3
			);

			v(
				new[] { 2,2 }
			);
			v(
				new[] { 2,3 }
			);


			v(
				new[] { 1,2,1 }
			);

			v(
				new[] { 1,2,3 }
			);

			v(
				new[] { 1,2,3 ,4,5}
			);
			v(
				new[] { 1,2,3 ,4,5}, 225,157
			);
			v(
				new[] { 2,1,7}, 2875,1000
			);

			v(
				new[] { 1},1
			);
			v(
				new[] { 1,1},2,1
			);
			v(
				new[] { 1,1,1},3,2
			);
			v(
				new[] { 1,1,1,1},5,3
			);

			v(
				new[] { 2,3,13 ,4,5}
			);


		}

		private void v(int[] ints)
		{
			v(
				ints, nilnul.num.quotient.str_.started.scala_.fractile_.ByReverse._Scala_0started(ints)
			);
		}

		private void v(IEnumerable< int> v1, int v2)
		{

			v(
				v1,
				v2,
				1
			);

		}

		private void v(IEnumerable<int> v1, int v2, int denominator)
		{
			v(
				v1, new DenomNonnil(v2,denominator)
			);
		}

		void v(IEnumerable<int> x, DenomNonnilI expected) {
			Assert.IsTrue(
				nilnul.num.quotient.Eq2.Singleton.Equals(
					num.integer.str_.started_.nonhead8positive.fractile.to_.quotienty_.convergenty_._SliderlyX._ToQuotient_0fractile(
						x
					)
					,
					expected
				)
			);
		}

	}
}
