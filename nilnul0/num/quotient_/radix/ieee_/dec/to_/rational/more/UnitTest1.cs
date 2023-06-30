using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Expressions;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix.ext.errable_.ieee_.dec.to_.rational.more
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
			vow("012340.05690");

			vow("-012340.05690");

			vow("1234567890123456789012345678");
			vow("7234567890123456789012345678");
			vow("8234567890123456789012345678");
			vow("9234567890123456789012345678");
			vow("19234567890123456789012345678");

			vow("79228162514264337593543950335");
			vow("-79228162514264337593543950335");

			vow("079228162514264337593543950335");
			vow("-079228162514264337593543950335");

			vow("7.9228162514264337593543950335");
			vow("-7.9228162514264337593543950335");



			//vow("0.79228162514264337593543950335"); //rounded ....34 not .....335
			//vow("-0.79228162514264337593543950335");


			//vow("89234567890123456789012345678");

			//vow("99234567890123456789012345678");
			
		}

		void vow(string txt) {

			//var txt = "-012340.05690";

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
