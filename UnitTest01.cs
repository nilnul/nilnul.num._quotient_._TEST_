using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.rational;

namespace nilnul.num.rational._test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void DecimalMius() {

			var a = new decimal_.Decimal_(225, 10, -2);
			var b = new decimal_.Decimal_(2, 10, 0);
			var c = a - b;
			
		}

		[TestMethod]
		public void DecimalToString()
		{
			decimal_.Decimal_ d = new decimal_.Decimal_(3,10,2);

			var c=d.ToString();

			decimal_.Decimal_ d1 = new decimal_.Decimal_(3, 10, 0);

			var c1 = d1.ToString();
			decimal_.Decimal_ d6 = new decimal_.Decimal_(3, 10, 1);

			var c6 = d6.ToString();


			decimal_.Decimal_ d2= new decimal_.Decimal_(3, 10, -5);

			var c2 = d2.ToString();


			decimal_.Decimal_ d4 = new decimal_.Decimal_(3, 10, -1);

			var c4 = d4.ToString();


			decimal_.Decimal_ d3 = new decimal_.Decimal_(0, 2, -5);

			var c3 = d3.ToString(); 
			
			decimal_.Decimal_ d9 = new decimal_.Decimal_(15, 10, -1);

			var c9 = d9.ToString();


		}
	}
}
