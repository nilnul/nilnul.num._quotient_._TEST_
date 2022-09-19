using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.quotient._test.slider_.eByExp
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void eByExp()
		{
			var slider = new nilnul.num.quotient.slider_.EByExp();

			for (int i = 0; i < 10; i++)
			{
				Debug.WriteLine(slider.current);
				slider.moveNext();

			}
		}
	}
}
