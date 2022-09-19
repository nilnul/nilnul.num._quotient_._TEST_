using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.quotient._test.slider.product.wallis
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Wallis()
		{
			var r = new nilnul.num.quotient.slider.product_.QuaterTau();

			for (int i = 0; i < 1000; i++)
			{
				r.moveNext();
				Debug.WriteLine(r.current);

			}
		}
	}
}
