using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.noninf_.sup_.whole_.max.ofBits
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
				new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
					0b1110_1111,		// EF
					0b0_111__1111
				} 
			);

			var txt = dbl.ToString();

			var significed = _RationableX._ToSignificed_assumeNormal(dbl);



			var dbl2quotient = significed.toDenomNonnil();

			var dbl2quotientSimplified = dbl2quotient.toSimplify();


			var powDecrement = BigInteger.Parse("179769313486231570814527423731704356798070567525844996598917476803157260780028538760589558632766878171540458953514382464234321326889464182768467546703537516986049910576551282076245490090389328944075868508455133942304583236903222948165808559332123348274797826204144723168738177180919299881250404026184124858368");


			Assert.IsTrue(
				nilnul.num.quotient.Eq2.Singleton.Equals(
					dbl2quotientSimplified
					,

					
					 powDecrement
				)
			);




			Debug.WriteLine(
				significed
			);
		}
	}
}
