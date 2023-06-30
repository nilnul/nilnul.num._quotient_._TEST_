﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_;
using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace nilnul.num.quotient_.radix.ext.errable_.ieee_.bin_.noninf_.nonsup_.nonnil_.min.toRational
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


			var dbl = double.Epsilon; //4.94E-324
			var txt = dbl.ToString();

			var bits = quotient_.radix.ext.errable_.ieee_._BinX.BytsAsLittle1st(dbl);

			Assert.IsTrue(
				nilnul.obj.str.Eq<byte>.Singleton.Equals(
					bits
					,
					new byte[] { 0b1, 0, 0, 0, 0, 0, 0b0000_0000, 0b0_0000000 }
				)
			);

			var x = _RationableX._ToSignificed_assumeNormal(dbl);


			var dbl2quotient = x.toDenomNonnil();

			var dbl2quotientSimplified = dbl2quotient.toSimplify();


			#region significed
			var significand =  1;

			const int bitsCountOfMantissa = 52;
			const int endExclusive = 1;
			const int all1sAsInf = 1;
			var indicBiased = (BigInteger.Pow(2, 11) - endExclusive - all1sAsInf);
			var indicand = 1 - 1023 - bitsCountOfMantissa;

			var target = new nilnul.num.quotient_._radix.basic.indiced.significed_.Bin(significand, indicand);

			var target2quotient = target.toDenomNonnil();
			var target2quotientSimplied = target2quotient.toSimplify();
			Assert.IsTrue(
	target.toDenomNonnil() == x.toDenomNonnil()
);


			#endregion



		}
	}
}
