using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.quotient._test.slider_.bernoulli_.recur
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void BernoulliRecur()
		{
			var s = new nilnul.num.quotient.slider_.bernoulli_.Recur();

			for (int i = 0; i < 15; i++)
			{
				Trace.WriteLine(
					s.current.toTxt()
				);
				s.moveNext();

			}
		}
	}
}
