using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num.quotient_.radix_.binary_.dbl.of_.one
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

			var bits = quotient_.radix.ext.errable_.ieee_._BinX.BytsAsLittle1st(dbl);

			Assert.IsTrue(
				nilnul.obj.str.Eq<byte>.Singleton.Equals(
					bits
					,
					new byte[] { 0b0, 0, 0, 0, 0, 0, 0b1111_0000, 0b0_011__1111 }
				)
			);

			var x = _RationableX._ToSignificed_assumeNormal(dbl);



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
