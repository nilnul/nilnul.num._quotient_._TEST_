using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num.quotient._test.radix.dec
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Dec1()
		{
			var t=nilnul.num.quotient.radix.recur.Dec.FroQuotient(1, 3);

			var t1=nilnul.num.quotient.radix.recur.Dec.FroQuotient(10, 3);

			var t2=nilnul.num.quotient.radix.recur.Dec.FroQuotient(10, 4);

			var t3=nilnul.num.quotient.radix.recur.Dec.FroQuotient(31, 99);


		}
	}
}
