using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using q = nilnul.num.quotient;

namespace nilnul.num._quotient_._TEST_.stream_.slider_.factorial
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var x = new q.stream_.slider_.Factorial();

			var fetched = nilnul.obj.stream._FetchX.Fetch(x, 10).ToArray();
			Debug.WriteLine(
				nilnul.obj.str.PhraseX.Phrase(fetched)
			);
		}
	}
}
