using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix_.binary_.dbl
{
	[TestClass]
	public class UnitTest1
	{
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
