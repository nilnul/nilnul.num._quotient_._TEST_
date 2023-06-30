using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj.range_;
using System;

namespace nilnul.num._quotient_._TEST_.eg_.fractile.to_.quotiently_._cascadely.slider.convergent.co_.alternate.growth.theorem
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

			for (i = 0; i < lastIndex - 1; i++)
			{
				var cross = slider.current;

				slider.moveNext();


				var cross1 = slider.ahead;

				var latestIndex = i + 2;

				Assert.IsTrue(
					cross1 - cross
					==
					 nilnul.num.quotient.of_.binary_.Divide.Singleton.op(
						num.integer.of_.unary_.pon.at_._BaseNegOneX.OfNegOneAsInt(latestIndex) * fractile[latestIndex]
						,
						(
							slider.ahead.denominator * cross.denominator
						)
					)

				);


			}

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

