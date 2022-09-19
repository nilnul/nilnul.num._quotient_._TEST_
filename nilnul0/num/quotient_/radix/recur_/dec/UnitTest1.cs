using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix.recur_.dec
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			var dec = new nilnul.num.quotient_.radix.recur_.Dec(

				80,
				-3
				,2

			);

			Debug.WriteLine(
				dec
			);

			///0.0080
			var dec1 = new nilnul.num.quotient_.radix.recur_.Dec(

				08,
				-2
				,2

			); /// 0.(08

			Debug.WriteLine(
				dec1
			);

			var dec11 = new nilnul.num.quotient_.radix.recur_.Dec(

				8,
				-3
				,2

			); /// 0.0(08

			Debug.WriteLine(
				dec11
			);


		}
	}
}
