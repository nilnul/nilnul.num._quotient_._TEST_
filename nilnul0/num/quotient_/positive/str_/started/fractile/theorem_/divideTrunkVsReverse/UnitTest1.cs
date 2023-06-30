using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.positive.str_.started.fractile.theorem_.divideTrunkVsReverse
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var rand = new System.Random();


			var length = rand.Next(1, 100);

			var adders = new int[length];

			for (int i = 0; i < length; i++)
			{
				adders[i] = rand.Next(1, 100000);

			}

			var reversed = adders.Reverse();

			Assert.IsTrue(
				nilnul.num.integer.str_.started_.nonhead8positive.fractile.to_._ToQuotientX._ToDenomNonnil_0fractile(
					adders
				)
				/
nilnul.num.integer.str_.started_.nonhead8positive.fractile.to_._ToQuotientX._ToDenomNonnil_0fractile(
					nilnul.obj.str_.started._DetoeX._Detoe_assumeStarted(adders)
				)
				==
				nilnul.num.integer.str_.started_.nonhead8positive.fractile.to_._ToQuotientX._ToDenomNonnil_0fractile(
					reversed
				)
				/
nilnul.num.integer.str_.started_.nonhead8positive.fractile.to_._ToQuotientX._ToDenomNonnil_0fractile(
					nilnul.obj.str_.started._DetoeX._Detoe_assumeStarted(reversed)
				)

			);
		}
	}
}
