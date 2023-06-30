using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num.quotient_.radix_.binary_.dbl.of_.dotOne.neg
{
	[TestClass]
	public class UnitTest1_dot1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Debug.WriteLine(
				BitConverter.IsLittleEndian
			);
			var txt = "-0.1";
			var x = _RationableX._ToSignificed_assumeNormal(double.Parse(txt) );

			var dbl2quotient = x.toDenomNonnil();
			var dbl2quotientSimplified = dbl2quotient.toSimplify();

			Assert.IsTrue(
				nilnul.num.quotient.re_.approx_.PerKilo.Singleton.re(
					dbl2quotientSimplified
					,

					nilnul.num.quotient_._radix.basic.indiced.significed_.Dec.Parse(txt).toDenomNonnil()
				)
			);



			Debug.WriteLine(
				x
			);
		}
	}
}
