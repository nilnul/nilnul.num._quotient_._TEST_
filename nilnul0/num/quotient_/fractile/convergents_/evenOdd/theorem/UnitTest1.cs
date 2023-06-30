using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_;
using nilnul.obj.range_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.num._quotient_._TEST_.eg_.fractile.to_.quotiently_._cascadely.slider.convergents_.evenOdd.theorem
{

	[TestClass]
	public class UnitTest1
	{

		/// <summary>
		/// . The even convergents x[2m] increase strictly with m, while the odd convergents	x[2m+1] decrease strictly.
		/// </summary>
		[TestMethod]
		public void TestMethod1()
		{
			__b(
			 new[] { -1 }

			);
			__b(
			 new[] { 0 }


			);

			__b(
			 new[] { 1 }
			);

			__b(
			 new[] { 11 }
			);

			var fractile = new[] { 1, 2, 3, 4, 5 };


			__b(
				fractile
			);



			__b(
			 new[] { 1, 1, 1, 1, 1 }

			);


			__b(
			 new[] { 1, 51, 1, 51, 21 }

			);


		}


		private void __b(integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._Slider slider, int[] fractile)
		{
			var lastIndex = fractile.Length - 1;

			int i = 0;

			var evens = new List<DenomNonnil>();
			var odds = new List<DenomNonnil>();
			evens.Add(slider.current);

			for (i = 0; i < lastIndex; i++)
			{
				var cross = slider.current;
				if (i % 2 == 0)
				{
					odds.Add(slider.ahead);
				}
				else
				{
					evens.Add(slider.ahead);
				}
				slider.moveNext();
			}
			odds.Reverse();
			Assert.IsTrue(
				nilnul.obj.str.be_.monotone_.lt_.CompDefault<DenomNonnil, num.quotient_.denomNonnil.Comp>.Unison.be(
					evens.Concat(
						odds
					)
				)

			);


		}

		private void __b(int[] fractile, int lastIndex)
		{
			if (lastIndex==0)
			{
				return;
			}
			__b(
				integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._Slider._Of_0plural(fractile), fractile
			);
		}


		private void __b(int[] fractile)
		{
			__b(fractile, fractile.Length - 1);
		}

	}
}

