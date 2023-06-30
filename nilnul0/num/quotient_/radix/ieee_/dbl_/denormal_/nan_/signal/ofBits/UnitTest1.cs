using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix_.binary_.dbl_.denormal_.nan_.signal_.pos
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var bitConverted = nilnul.num.quotient_.radix.ext.errable_.ieee_._BinX.OfBitsInLittle1st(
				new byte[] {0,0,0,0,   0,0,0b1111_1100,0b0_1111111 }	
			);


			Debug.WriteLine(bitConverted) ;


		}
	}
}
