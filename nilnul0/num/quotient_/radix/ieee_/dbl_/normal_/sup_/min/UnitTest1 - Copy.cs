using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.noninf_.sup_.min
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

			var txt = "1";

			var dbl = double.Parse(txt);

			dbl =  nilnul.num.quotient_.radix.ext.errable_.ieee_._BinX.OfBitsInLittle1st(
				new byte[] { 0, 0, 0, 0, 0, 0, 0b0001_0000, 0b0_0 } //1.0 * 2^ (1-1023)
			);

			txt = dbl.ToString();


			var bits = quotient_.radix.ext.errable_.ieee_._BinX.BytsAsLittle1st(dbl);

			//Assert.IsTrue(
			//	nilnul.obj.str.Eq<byte>.Singleton.Equals(
			//		bits
			//		,
			//		new byte[] { 0b0, 0, 0, 0, 0, 0, 0b1111_0000, 0b0_0111111 }
			//	)
			//);

			var significed = _RationableX._ToSignificed_assumeNormal(dbl);



			var dbl2quotient = significed.toDenomNonnil();

			var dbl2quotientSimplified = dbl2quotient.toSimplify();



			Assert.IsTrue(
				nilnul.num.quotient.re_.approx_.PerKilo.Singleton.re(
					dbl2quotientSimplified
					,

					nilnul.num.quotient_._radix.basic.indiced.significed_.Dec.Parse(txt).toDenomNonnil()
				)
			);



			Debug.WriteLine(
				significed
			);
		}
	}
}
