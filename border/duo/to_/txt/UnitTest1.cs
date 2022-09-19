using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.quotient._test.border.duo.to_.txt
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void BorderDuoToTxt()
		{

			var borderDuo =  nilnul.num.quotient.border.Duo.CreateClose(0,1);

			Debug.WriteLine(
				borderDuo.ToString()
				);
		}
	}
}
