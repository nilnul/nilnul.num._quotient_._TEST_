using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num._quotient_._TEST_.eg_.fractile.to_.quotiently_._cascadely.slider.theorem_.____n_kPlus__d_k___n_k__d_kPlus.vsPrev
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			///

			var fractile = new[] { 1, 2, 3, 4, 5 };


			__b(
				fractile
			);



		}


		/// <summary>
		/// moved any steps;
		/// </summary>
		/// <param name="slider"></param>
		/// <returns></returns>
		System.Numerics.BigInteger crossWithNext(num.integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._Slider slider)
		{

	
			return slider.ahead.numerator * slider.current.denominator - slider.current.numerator * slider.ahead.denominator
			;
		}




		
		void __b(num.integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._Slider slider, int lastIndex)
		{
			int i = 0;




			for ( i = 0; i < lastIndex; i++)
			{
				var cross = crossWithNext(slider);

				slider.moveNext();
				var cross1 = crossWithNext(slider);

				Assert.IsTrue(
					cross1==-cross
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
				integer.str_.started_.nonhead8positive.fractile.convergents_.plural_._Slider._Of_0plural(fractile), lastIndex
			);
		}
		private void __b(int[] fractile)
		{
			__b(fractile,fractile.Length-1);
		}

	}
}

