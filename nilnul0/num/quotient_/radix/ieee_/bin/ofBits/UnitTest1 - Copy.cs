using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.ofBits
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
				new byte[] {
					0x63, 0x6f, 0x6d, 0x70
					,
					0x75, 0x74,
					0x65,	
					0x72
				} 
			);

			var txt = dbl.ToString();



			var significed = _RationableX._ToSignificed_assumeNormal(dbl);



			var dbl2quotient = significed.toDenomNonnil();

			var dbl2quotientSimplified = dbl2quotient.toSimplify();



			var accuracy = 0.000001e243;

			Assert.IsTrue(
				new nilnul.num.quotient.re_.Approx(
					num.quotient_.radix.ext.errable_.ieee_.bin_._RationableX._ToSignificed_assumeNormal(
						.000001e243
					).toDenomNonnil()

				).re(
					dbl2quotientSimplified
					,

					num.quotient_.radix.ext.errable_.ieee_.bin_._RationableX._ToSignificed_assumeNormal(
						1.144493e243
					).toDenomNonnil()
				)
			);




			Debug.WriteLine(
				significed
			);
		}
	}
}
