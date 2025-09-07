using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.ofBits.bitsEqLong
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

			var bytes = new byte[] {
					0x63, 0x6f, 0x6d, 0x70
					,
					0x75, 0x74,
					0x65,
					0x72
				};

			var dbl =   nilnul.num.quotient_.radix.ext.errable_.ieee_._BinX.OfBitsInLittle1st(
				bytes
			);

			var longed = BitConverter.ToUInt64( BitConverter.GetBytes(dbl),0);

			var t=BitConverter.ToString(bytes);

			Debug.WriteLine(t);

			Assert.IsTrue(
				longed==8243_1227_4071_7776_739ul // 0x7265_7475_706d_6f63;
			);


		}
	}
}
