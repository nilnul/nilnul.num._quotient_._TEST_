using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.quotient_;
using System;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix_.floaty_.dec.parse
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			v("", 0);

			v("0", 0);
			v("00", 0);

			v("000", 0);

			v("1", 1);
			v("01", 1);
			v("001", 1);

			v("1001", 1001);
			v("01001", 1001);



			v(".", 0);
			v("0.", 0);
			v("00.", 0);


			v(".0", 0);
			v("0.", 0);
			v("0000.", 0);

			v("0.0", 0);
			v("00.", 0);
			v(".00", 0);

			v(".000", 0);
			v("0.00", 0);
			v("00.0", 0);
			v("000.", 0);

			v("0001.", 1);
			v("000.1", 1,10);

			v(".0001", 1,10000);
			v("0.0001", 1,10000);
			v("00.0001", 1,10000);

			v(".10001", 10001,100000);
			v("0.10001", 10001,100000);
			v("00.10001", 10001,100000);
			v("0000.10001", 10001,100000);

			v("0000100.01", 10001,100);
			v("00100.01", 10001,100);
			v("100.01", 10001,100);


		}

		private void v(string v1, int v2)
		{
			v(v1,  new DenomNonnil (v2));
		}
		private void v(string v1, int v2,int d)
		{
			v(v1,  new DenomNonnil (v2,d));
		}


		void v(string s, nilnul.num.quotient_.DenomNonnil f) {
			Assert.IsTrue(
				//nilnul.num.quotient_.radix._ToX.ToSignified
				nilnul.num.quotient_.radix_.floaty_.dec._ParseX.Parse(s).toDenomNonnil()
				==
				f

			);
		}
		void v(string s, nilnul.num.quotient_.radix_.Floaty f) {
			Assert.IsTrue(
				//nilnul.num.quotient_.radix._ToX.ToSignified
				nilnul.num.quotient_.radix_.floaty_.dec._ParseX.Parse(s).toDenomNonnil()
				==
				f.toDenomNonnil()

			);
		}

	}
}
