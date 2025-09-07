using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num._quotient_._TEST_.of_.dbl
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// The Double type complies with the IEC 60559:1989 (IEEE 754) standard for binary floating-point arithmetic.
		/// ignificand or mantissa	0-51
		/// Exponent	52-62
		/// Sign(0 = Positive, 1 = Negative)   63
		/// </summary>
		/// <summary>
		/// x = s * m * b^e
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		[TestMethod]
		public void TestMethod1()
		{
			var x = 0d;
			var bitConverted = BitConverter.GetBytes(x);

			string message = string.Join(
								" ",
							bitConverted.Select(
								x =>
								Convert.ToString(x, 2).PadLeft(8, '0')
							//x.ToString()
							)
						);
			Debug.WriteLine(
				message
			);

		}
	}
}
