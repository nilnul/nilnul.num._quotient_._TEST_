using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Expressions;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix.ext.errable_.ieee_.dec.of_.bits
{
	[TestClass]
	public class UnitTest1
	{
		/// <summary>
		/// https://learn.microsoft.com/en-us/dotnet/api/system.decimal.getbits?view=net-7.0
		/// </summary>
		[TestMethod]
		public void TestMethod1()
		{
			var precisionInInts = new int[] {
				01234005690	//	0x1234
				,
				0
				,
				0
			};

			var precision = new BitArray(precisionInInts);



			BitArray unused = new BitArray(16);
			//unused.Set(0, true);


			byte mantissaInInt = 2;
			var mantissa //= new BitArray(23-16+1); //width: 8; val: 0-28
			//mantissa
				= new BitArray(new byte[] { mantissaInInt });


			var unusedAftMantissa = new BitArray(30-24+1); // width: 7
			//unusedAftMantissa.Set(6, true);

			//var sign = 0; //width:1; //positive;natural;

			var otherQuatet // = new BitArray(4 * 8);
				//otherQuatet
			=
			new BitArray(
					unused.Cast<bool>().Concat(
						mantissa.Cast<bool>()
					).Concat(
						unusedAftMantissa.Cast<bool>()
					).Append(
						false //positive
					).ToArray()
			);
			

			var allBits = new BitArray(
				precision.Cast<bool>().Concat( otherQuatet.Cast<bool>()).ToArray()
			);

			var allBitsAsInts = new int[4];

			allBits.CopyTo(allBitsAsInts, 0);

			var decim =new  Decimal(allBitsAsInts);

			Debug.WriteLine(decim);


			Assert.AreEqual(decim,012340056.90m);
		}
	}
}
