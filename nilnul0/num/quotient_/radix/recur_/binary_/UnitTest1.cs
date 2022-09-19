using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix.recur_.binary_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			/*
			  这是由于浮点计数的时候（看看32位还是64位），
			十进制的0.1用二进制表示
			 0.000110011001100...，
			十进制的0.2用二进制表示
			0.001100110011001...。
			他们二进制之下都是无穷循环小数（有理数都这样），但是浮点计数有截断。因为四舍五入截断后二进制的和加起来之后再转换为十进制，出现0.300000004的情况。

			 @bennywa42354892

			 */
		}
	}
}
