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
	public class Basel_testClass
	{
		[TestMethod]
		public void Basel_test()
		{
			var wallis = new Basel();

			

			Assert.AreEqual(
				wallis.next(), 1
				
			);

			Assert.AreEqual(
				wallis.next(), new Q(5,4)	
			);
			Debug.WriteLine(nilnul.num.quotient.radix.Recur.Q2Recur_decimal( Basel.Item(1000)*6, 100));
			



		}
	}
}
