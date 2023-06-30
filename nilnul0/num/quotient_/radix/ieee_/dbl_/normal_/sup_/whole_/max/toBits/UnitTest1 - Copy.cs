using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.noninf_.sup_.whole_.max.toBits
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


			var dbl = double.MaxValue; //4.94E-324
			var txt = dbl.ToString();

			var bits = quotient_.radix.ext.errable_.ieee_._BinX.BytsAsLittle1st(dbl);

			Assert.IsTrue(
				nilnul.obj.str.Eq<byte>.Singleton.Equals(
					bits
					,
					new byte[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
						0b1110_1111,		// EF
						0b0_111__1111
					}
				)
			);




		}
	}
}
