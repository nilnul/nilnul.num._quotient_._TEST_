using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using q = nilnul.num.quotient;
using System.Diagnostics;

namespace nilnul.num.quotient._test.stream._subS.arithmeticoGeometric
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ArithmeticGeometric()
		{
			var stream = new q.stream._subtypeS.ArithmeticoGeometric(
				q.stream._subtypeS.Arithmetic.Create_givenAsHead(2, 1)
				,
				new q.stream._subtypeS.Geometric_givenHead(
					Q.CreateFourth(), 
					
					q._radix.Dec.Parse(".5")
			
				)
			);

			Debug.WriteLine(
				q.stream._subtypeS.arithmeticoGeometic.be.rateAbsLtOne.asserted.Sum._Eval(stream)	
			);
		}
	}
}
