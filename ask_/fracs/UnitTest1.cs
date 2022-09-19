using System;
using System.Diagnostics;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q = nilnul.num._quotient.Dividing;

namespace nilnul.num._quotient_._TEST_.ask_.fracs
{
#if TRIAL

	[TestClass]
#endif
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
		//If we allow negative integers, a=4, b=-1, c=11 is a solution.
		//Reference: https://www.physicsforums.com/threads/find-positive-integer-solutions-to-a-b-c-b-a-c-c-a-b-4.922057/

//What happens if we replace 4 by other integers?
//a/(b+c)+b/(a+c)+c/(a+b)=178?
//There are integer solutions, but the smallest one has nearly 400 million digits.

			for (BigInteger a = 1; ; a++)
			{
				for (BigInteger b = 1; b <= a; b++)
				{
					for (BigInteger c = 1; c < b; c++)
					{
						if (new Q(a, b + c)
							+
							new Q(b, c + a)
							+
							new Q(c, a + b) == 4
						)
						{
							Debug.WriteLine(
								$"{a},{b},{c}"
							);
							return;
						}
					}
				}
			}
		}
	}
}