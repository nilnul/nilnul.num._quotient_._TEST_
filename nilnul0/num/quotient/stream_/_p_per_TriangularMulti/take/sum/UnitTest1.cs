using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.quotient.stream_._p_per_TriangularMulti.take.sum
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var r = Sum.Eval(49);
			Debug.WriteLine(
				r
			);

			Debug.Assert(
				nilnul.num.quotient.Eq1.Singleton.Equals(
					r, 

					 nilnul.num.Quotient.CreateOne() - 
					 nilnul.num.Quotient.CreateUnit(25*51)
					 //1 - 1 / (25 * 51)
				)
			);

		}
	}
}
