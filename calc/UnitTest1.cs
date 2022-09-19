using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._quotient_._TEST_.calc
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var t = op(
				op(
				op(
					op(251, 502),
					1004
				), 2008)
				, 2008);

			Debug.WriteLine(
				t
			);

			Debug.WriteLine(
				nilnul.num.quotient_.radix_.Dec1.OvQuotient_throwIfResidue(
					t,
					2
				)
			);


			nilnul.num.Quotient1 op(Quotient1 x, Quotient1 y)
			{
				return x * y / (x + y);
			}
		}
	}
}
