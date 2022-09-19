using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using nilnul.str.to.txt;

namespace nilnul.num.quotient._test._stream_.stream_.bernoulli
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Bernoulli()
		{
			Debug.WriteLine(
				nilnul.num.quotient.str_.Bernoulli.Enumerate().Take(30).Select(x=>x.toTxt()).ToTxt()	
			);
			var b = new nilnul.num.quotient.slider_.Bernoulli();
			for (int i = 0; i < 10; i++)
			{
				Debug.WriteLine(
					b.current
				);
				b.moveNext();
			}
		}
	}
}
