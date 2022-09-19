using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using q = nilnul.num.quotient;


namespace nilnul.num._quotient_._TEST_.stream_.slider_.factorial.inverse
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			//var y= new q.stream_.factorial.Inverse();

			//var series = new nilnul.num.quotient.stream.slider.Series1(y);

			//for (int i = 0; i < 10; i++)
			//{

			//	Debug.WriteLine(series.current);
			//	series.moveNext();

			//}

			var x = new q.stream_.slider_.factorial.Inverse();

			var fetched = nilnul.obj.stream._FetchX.Fetch(x, 10).ToArray();
			Debug.WriteLine(
				nilnul.obj.str.PhraseX.Phrase(fetched)
			);

		}
	}
}
