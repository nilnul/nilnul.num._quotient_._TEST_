using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.rational;

using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace nilnul.num.rational._test
{
	[TestClass]
	public class Recur
	{
		[TestMethod]
		public void RecurTest()
		{
			Rational_InheritFraction2 r = Rational_InheritFraction2.Create(1, 3);

			var decimal_ = rational.float_.Periodic.FroRational(10, r);

			var decimalStr = decimal_.ToString();
			Assert.AreEqual(
				decimalStr
				,
				"0.(3"
				//"0.(142857)"
			);


			var str_1to7 = rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(1, 7)
				).ToString();

			Assert.AreEqual(
				str_1to7
				,
				"0.(142857"
				//"0.(142857)"
			);
			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(1, 17)
				).ToString()
				,
				"0.(0588235294117647"
			);
			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(1, 19)
				).ToString()
				,
				"0.(052631578947368421"
			);

			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(1, 23)
				).ToString()
				,
				"0.(0434782608695652173913"
			);
			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(1, 29)
				).ToString()
				,
				"0.(0344827586206896551724137931"
			);
			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(1, 97)
				).ToString()
				,
				"0.(01030927 83505154 63917525 77319587 62886597 93814432 98969072 16494845 36082474 22680412 37113402 06185567  )".Replace(" ", "").Replace(")", "")
			);
			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(1, 3)
				).ToString()
				,
				"0.(3)".Replace(" ", "").Replace(")", "")
			);
			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(3, 7)
				).ToString()
				,
				"0.(428571)".Replace(" ", "").Replace(")", "")
			);


			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(1, 11)
				).ToString()
				,
				"0.(09)".Replace(" ", "").Replace(")", "")
			);
			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(1, 13)
				).ToString()
				,
				"0.(076923)".Replace(" ", "").Replace(")", "")
			);


			Assert.AreEqual(
				rational.float_.Periodic.FroRational(
					Rational_InheritFraction2.Create(0, 1)
				).ToString()
				,
				"0".Replace(" ", "").Replace(")", "")
			);

			var testCases = new object[,] { 
				{0,1,"0"},
				{-0,1,"0"}
				,
				{1,1,"1"}
				,
				{2,1,"2"}



				,
				{9,1,"9"}
				,
				{10,1,"10"}
				,
				{11,1,"11"}
				,{19,1,"19"}




				,
				{20,1,"20"}
				,
				{-1,1,"-1"}
				,
				{-2,1,"-2"}
				,
				{1,2,"0.5"}



				,
				{1,3,"0.(3)"}
				,
				{7,3,"2.(3)"	 }
				,{-1,3,"-0.(3)"}
				,{-7,3,"-2.(3)"}
				,{100,3,"33.(3)"}
				,{-100,3,"-33.(3)"}
				,{1,37,"0.(027)"}
				,{1,41,"0.(02439)"}
				,{4,9000,"0.000(4)" }
				,{1111,900,"1.23(4)"}
				,{200,3,"66.(6)"}
				,{-200,3,"-66.(6)"}
				,
			{10,99,"0.(10)"}
			,{1,99,"0.(01)"}
			,{109,990,"0.1(10)"}
			
			};

			for (int i = 0; i < testCases.GetLength(0); i++)
			{


				Assert.AreEqual(
					rational.float_.Periodic.FroRational(
						Rational_InheritFraction2.Create((int)(testCases[i, 0]), (int)testCases[i, 1])
					).ToString()
					,
					(testCases[i, 2] as string).Replace(")", "")
				);

				if ((int)testCases[i, 0] > 0 && (int) testCases[i,1]>0)
				{

					Rational_InheritFraction2 r1 =

						Rational_InheritFraction2.Create(-(int)(testCases[i, 0]), (int)testCases[i, 1]);

					

					rational.float_.Periodic periodic = rational.float_.Periodic.FroRational(
																	r1
																);

					var periodic1111 = num.quotient_.radix.Recur._FroQuotient(10,

						new Quotient1(
							r1.numerator1
							,
							r1.denominatorAsBigInt
						)
					);
					//var periodic22222222 = num.quotient_.radix.recur_.Recur._FroQuotient(10,

					//	new Quotient1(
					//		r1.numerator1
					//		,
					//		r1.denominatorAsBigInt
					//	)
					//);


					string actual1 = quotient_.radix_.floaty.recur_.mantissaed.of_.coerce_._OfRecurX.ToMantissaed( periodic1111).phrase8decollapse();
					string expected = "-" + (testCases[i, 2] as string).Replace(")", "");
					Assert.AreEqual(
						actual1
						,
						expected
					);


				}



			}

			var testCasesBinary = new object[,] { 
				{0,1,"0"},
				{-0,1,"0"}
				,
				{1,1,"1"}
				,
				{2,1,"10"}
				,
				{1,3,""				 }


			};






		}
	}
}
