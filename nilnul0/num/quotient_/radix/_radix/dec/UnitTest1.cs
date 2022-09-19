using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using Q = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num.quotient._test._radix.dec
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Dec()
		{

			Debug.Assert(
				nilnul.num.quotient._radix.Dec.Parse("")
				==0	
			);
			Debug.Assert(
				nilnul.num.quotient._radix.Dec.Parse(".95")
				== new Q(95,100)	
			);

			Debug.Assert(
				nilnul.num.quotient._radix.Dec.Parse("9.5")
				== new Q(950,100)	
			);

			
		}
	}
}
