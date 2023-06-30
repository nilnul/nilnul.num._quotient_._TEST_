using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix_.binary_.dbl_.denormal_.inf_.neg
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var x = double.NegativeInfinity;
			var bitConverted = nilnul.num.quotient_.radix.ext.errable_.ieee_._BinX.BytsAsLittle1st(x);

			Assert.IsTrue(
				nilnul.obj.str.Eq<byte>.Singleton.Equals(
					bitConverted
					,
					new byte[] {0,0,0,0,   0,0,0b11110000,0xff }
				)
			);


		}
	}
}
