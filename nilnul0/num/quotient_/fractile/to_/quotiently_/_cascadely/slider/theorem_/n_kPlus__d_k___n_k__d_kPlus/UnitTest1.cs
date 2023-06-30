using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num._quotient_._TEST_.eg_.fractile.to_.quotiently_._cascadely.slider.theorem_.n_kPlus__d_k___n_k__d_kPlus
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			///

			var fractile = new[] { 1, 2, 3, 4, 5 };

			var lastIndex = fractile.Length - 1;

			__b(
				fractile
			);



		}


		/// <summary>
		/// moved any steps;
		/// </summary>
		/// <param name="slider"></param>
		/// <returns></returns>
		bool b(num.integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._Slider slider, int currentIndex)
		{

	
			return slider.ahead.numerator * slider.current.denominator - slider.current.numerator * slider.ahead.denominator
				==
				nilnul.num.integer.op_.unary_.polyn._BaseNegOneX.OfNegOneAsInt(currentIndex)

			;
		}


		void v(num.integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._Slider slider, int currentIndex)
		{



			Assert.IsTrue(b(slider, currentIndex));
		}
		void __b(num.integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._Slider slider, int lastIndex)
		{

			int i = 0;
			v(slider, i);

			for (i = 1; i < lastIndex; i++)
			{
				slider.moveNext();
				v(slider, i);


			}

		}

		private void __b(int[] fractile, int lastIndex)
		{
			if (lastIndex==0)
			{
				return;
			}
			__b(
				integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._Slider._Of_0plural(fractile), lastIndex
			);
		}
		private void __b(int[] fractile)
		{
			__b(fractile,fractile.Length-1);
		}

	}
}

