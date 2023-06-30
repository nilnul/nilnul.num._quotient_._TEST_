using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.noninf_.sup_.whole_.upperIncre.ofBits
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
				new byte[] { 1, 0, 0, 0, 0, 0, 0b0100_0000, 0b0_100__0011 }  // 0b1.0 * 2^53
			);

			var txt = dbl.ToString();



			var significed = _RationableX._ToSignificed_assumeNormal(dbl);



			var dbl2quotient = significed.toDenomNonnil();

			var dbl2quotientSimplified = dbl2quotient.toSimplify();

			var powDecrement = (1l << 53) +2; //9007199254740992


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
