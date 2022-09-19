using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using Assert_ms = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace nilnul.num.quotient._test.stream.fibonacci.item
{
	[TestClass]
	public class Poly
	{
		[TestMethod]
		public void Fibonacci_Item_Poly_Test() {

			_testFunc(0, 0);
			_testFunc(1, 1);
			_testFunc(2, 1);
			_testFunc(3, 2);
			_testFunc(4, 3);
			_testFunc(5, 5);
			_testFunc(6, 8);
			_testFunc(7, 13);
			_testFunc(8, 21);
			_testFunc(9, 34);



		}
		[TestMethod]
		public void Fibonacci_Item_PolyOfPhiPsi_Test()
		{

			Action<BigInteger,BigInteger> _testFunc = (x, y) => _testFunc_ofPhiPsi(x, y);

			_testFunc(0, 0);
			_testFunc(1, 1);
			_testFunc(2, 1);
			_testFunc(3, 2);
			_testFunc(4, 3);
			_testFunc(5, 5);
			_testFunc(6, 8);
			_testFunc(7, 13);
			_testFunc(8, 21);
			_testFunc(9, 34);



		}

		private void _testFunc(BigInteger index, BigInteger image)
		{

			Assert_ms.AreEqual(nilnul.num.quotient.stream.fibanacci.ComputeItemByPoly.Eval_bySlope(index), image);


		}

		private void _testFunc_ofPhiPsi(BigInteger index, BigInteger image)
		{

			Assert_ms.AreEqual(nilnul.num.quotient.stream.fibanacci.ComputeItemByPoly_ofPhiPsi.Eval(index), image);


		}

	}
}
