using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.rational;

using Assert1 = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System.Diagnostics;
using nilnul.num.quotient._streamS;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num.quotient._test._streamS
{
	[TestClass]
	public class Wallis_testClass
	{
		[TestMethod]
		public void Wallis_test()
		{
			var wallis = new Wallis();

			

			Assert.AreEqual(
				wallis.next(), 2
				
			);

			Assert.AreEqual(
				wallis.next(), new Q(4,3)	
			);
			Debug.WriteLine(quotient.radix.Recur.Q2Recur_decimal(   Wallis.Item(100000)*2, 100));
			






		}
	}
}
