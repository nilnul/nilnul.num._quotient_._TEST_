using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.rational;

using Assert1 = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using System.Diagnostics;

namespace nilnul.num.quotient._test.stream.eg
{
	[TestClass]
	public class Pi_AlterOddUnit_test
	{
		[TestMethod]
		public void Pi_AlterOddUnit()
		{
			var stream = new nilnul.num.quotient.stream.cauchy.Pi_4OddAlterUnit();


			for (int i = 0; i < 10000; i++)
			{
				stream.next();

			}


			Debug.WriteLine(
				nilnul.num.quotient.radix.DecX._ToDec(  stream.next(),10)
			);

			







		}
	}
}
