using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num.quotient_.radix_.binary_.dbl.of_.nil.neg
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Debug.WriteLine(
				BitConverter.IsLittleEndian
			);
			var txt = "-0";
			var parsedDbl =double.Parse(txt);



				
			parsedDbl = 1/ double.NegativeInfinity;
			//parsedDbl = -0d;
			//parsedDbl= double.NegativeInfinity

			var x = _RationableX._ToSignificed_assumeNormal( parsedDbl);

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
