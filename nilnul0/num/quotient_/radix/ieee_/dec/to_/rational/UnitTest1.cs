using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Expressions;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix.ext.errable_.ieee_.dec.to_.rational
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// https://learn.microsoft.com/en-us/dotnet/api/system.decimal.getbits?view=net-7.0
		/// </summary>
		/// A numeric value might have several possible binary representations; all are equally valid and numerically equivalent. Note that the bit representation differentiates between negative and positive zero. These values are treated as being equal in all operations.
		[TestMethod]
		public void TestMethod1()
		{


			var txt = "-012340.05690";

			var decim = decimal.Parse(txt);

			//	-012340.05690m
				;

			var q = nilnul.num.quotient_.radix.floaty_.dec.to_._RationableX._ToSignificed_assumeValid(decim);



			Debug.WriteLine(decim);


			Assert.IsTrue(
				nilnul.num.quotient.Eq2.Singleton.Equals(
					q.toDenomNonnil()
					,
					nilnul.num.quotient_.radix_.DecX.Parse2significed(txt).toDenomNonnil()
				)
			);
		}


	}
}
