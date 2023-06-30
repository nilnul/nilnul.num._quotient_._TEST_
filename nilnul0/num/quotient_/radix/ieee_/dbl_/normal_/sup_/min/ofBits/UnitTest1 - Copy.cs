using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.noninf_.sup_.min.ofBits
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


			var dbl =   nilnul.num.quotient_.radix.ext.errable_.ieee_._BinX.OfBitsInLittle1st(
				new byte[] { 0, 0, 0, 0, 0, 0, 0b0001_0000, 0b0_0 } //1.0 * 2^ (1-1023)
			);

			var txt = dbl.ToString();



			var significed = _RationableX._ToSignificed_assumeNormal(dbl);



			var dbl2quotient = significed.toDenomNonnil();

			var dbl2quotientSimplified = dbl2quotient.toSimplify();



			Assert.IsTrue(
				nilnul.num.quotient.re_.approx_.PerKilo.Singleton.re(
					dbl2quotientSimplified
					,

					 nilnul.num.quotient.of_.unary_._IndicX.DenomNonnil(2, -1022 )
				)
			);
			Assert.IsTrue(
				nilnul.num.quotient.Eq2.Singleton.Equals(
					dbl2quotientSimplified
					,

					 nilnul.num.quotient.of_.unary_._IndicX.DenomNonnil(2, -1022 )
				)
			);




			Debug.WriteLine(
				significed
			);
		}
	}
}
