using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix.ext.errable_.ieee_.dec.to_.bits
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var d = 0m;
			var bits = Decimal.GetBits(d);

			Assert.AreEqual(bits.Length,4);
		}
	}
}
