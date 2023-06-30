using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.rational.cf;

namespace test
{
	[TestClass]
	public class Cf
	{
		[TestMethod]
		public void DoubleToRational()
		{
			
		
			

			Test(0);
			Test(0.001);
			Test(.5);
			Test(.7);
			Test(.9);
			Test(1);
			Test(1.2)	;

			Test(2);
			Test(2.5);
			Test(21.3223);

			Test(-.2);
			Test(-.7);
			Test(-1);
			Test(-1.5);
			Test(-2);
			Test(-3);
			Test(-100.21234);





		}

		public void Test(double d) { 


			var rational2_1 = ContinuedFraction2.ToRational(d, 0);

			var rational2 = ContinuedFraction2.ToRational(d, 1);

			var rational3 = ContinuedFraction2.ToRational(d, 2);
			var rational4 = ContinuedFraction2.ToRational(d, 5);
		
		}
	}
}
