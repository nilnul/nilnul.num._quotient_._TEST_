using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using q = nilnul.num.quotient;

namespace nilnul.num.quotient._test.stream._seriesS
{
	[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
	public class MyTestClass
	{

		[TestMethod]
		public void AlternateInverse()
		{
			var series = new q.stream._seriesS.AlternateInverse();

			var asEnumerable = series.AsEnumerable();

			//var i = 10000000;
			//while (i-->0)
			//{
			//	series.next();
			//}
			Debug.WriteLine(
				q._radix.Dec.FroQ(asEnumerable.ElementAt(10),1000)	
			);
		}

	}
}
