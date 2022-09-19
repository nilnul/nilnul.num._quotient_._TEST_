using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.quotient._test.slider_.fro_.streamProduct_
{
	[TestClass]
	public class PoPowK_over_numPlus_testClass
	{

		public string t = "0.27202905498213316295";
		[TestMethod]
		public void PoPowK_over_numPlus()
		{
			throw new Exception("too long running; (over quite a few or over ten minutes.)");
			var slider = new nilnul.num.quotient.slider_.fro_.streamProduct_.Square_over_SquarePlus();

			var c = slider.current;
			slider.moveNext();
			var c1 = slider.current;

			var precision = nilnul.num.quotient.op_.Poly.OneTenthPoly(
t.Length - 2
					);

			var precisonNeightbor = nilnul.num.quotient.Neighbor.Create(precision);


			while (

				precisonNeightbor.notContains(c-c1)
				 
				 )
			{

			 c = slider.current;
			slider.moveNext();
			 c1 = slider.current;


			}

			var decTxt=nilnul.num.quotient.radix.Dec.FroQuotient(
				c1
				,

				t.Length - 1
			);
			Debug.WriteLine(decTxt);

		}
	}
}
