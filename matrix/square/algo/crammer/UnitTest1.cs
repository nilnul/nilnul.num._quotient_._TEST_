using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient._radix;
using nilnul.num.quotient.matrix.square.be.nonSingular.algo;
using System.Diagnostics;

namespace nilnul.num.quotient._test.matrix.square.algo.crammer
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void Crammer_testClass_forQuestion_SheepCartedBack()
		{
			const int dimension = 5;

			var coeff = new Quotient[dimension, dimension] {
				{
					Q.Divide(1,12)
					,
					Q.Divide(-1,3)
					,0
					,0
					,0
				}
				,
				{
					0,0,
					Q.Divide(1,18)
					,
					Q.Divide(-1,3)
					,
					0
				}
				, {
					-1
					,
					1,
					1,
					1,
					0
				}
				, {
					0
					,0
					,0
					,-Q.CreateThird()
					,
					Q.CreateThird()

				}

				, {
					Q.CreateThird()
					,
					Q.Divide(-1,12)
					,
					0
					,
					Q.Divide(-1,12)
					,
					Q.CreateThird()
				}

			};

			var _9_5 = Dec.Parse("9.5");

			var b = new Q[dimension] {
				0,0,0,0,

				Q.Divide(
					Dec.Parse("9.5"),
					
					3	
				)
				-_9_5 / 12

			};

			var answer = Crammer._Solve(coeff, b);
			Debug.WriteLine(nilnul.collection.array.X.ToTxt( answer));

			var time = answer[0] / 12 + answer[2] / 18 + (_9_5 - answer[1] - answer[3]) / 12;

			Debug.WriteLine(time);


		}
	}
}
