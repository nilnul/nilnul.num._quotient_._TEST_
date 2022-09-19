using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul.num._quotient_._TEST_.ask_.NewFolder1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Debug.WriteLine(
				slnCount(10,15)  //不就是多项式  (1 + x + x^2 + x^3 + x^4)^10 展开后x^15的系数么
			); ;
		}

		int slnCount(int varsCount, int expected) {
			if (varsCount==0)
			{
				if (expected==0)
				{
					return 1;
				}
				
				return 0;
				
			}
			var r = 0;
			for (int assigned = 0; assigned < 5; assigned++)
			{
				r += slnCount(
					varsCount-1
					,
					expected-assigned
				);
			}
			return r;
		}
	}
}
