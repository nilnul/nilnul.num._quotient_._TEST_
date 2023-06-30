using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.noninf_.sup_.whole_.max.ofBits.toRational
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

			var significand = BigInteger.Pow(2, 53)-1;

			const int bitsCountOfMantissa = 52;
			const int endExclusive = 1;
			const int all1sAsInf = 1;
			var indicBiased = (BigInteger.Pow(2, 11) - endExclusive - all1sAsInf);
			var indicand = indicBiased - 1023 - bitsCountOfMantissa;

			var target = new nilnul.num.quotient_._radix.basic.indiced.significed_.Bin(significand, indicand);

			var target2quotient = target.toDenomNonnil();
			var target2quotientSimplied = target2quotient.toSimplify();

			Assert.IsTrue(
				target.toDenomNonnil() == significed.toDenomNonnil()
			);



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
