using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using System.Collections.Generic;
using System.Diagnostics;

namespace nilnul.num.quotient._test.app_.problem1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void productOfSomeFacts()
		{

			var list = new List<Q1>();

			for (int i = 2; i < 51; i++)
			{
				var factorial = nilnul.num.convert_._TriangularSumX._Eval_byLoop(i);
				list.Add(
					new Q1(
						factorial-1
						,
						factorial
					)
				);
			}

			var r = nilnul.num.quotient.aggregate_._ProductX.Product(list);

			Debug.WriteLine(r);

		}
	}
}
