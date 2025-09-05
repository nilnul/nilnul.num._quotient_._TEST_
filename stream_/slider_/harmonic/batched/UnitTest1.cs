using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.quotient.stream_.slider_.harmonic.batched
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			/// for n-wide number x,where n is positive
			///  sum( 1/x ), for all n-wide x
			///
			/// here x is between:
			///		10^(n-1)
			///		, and
			///		10^n -1
			///
			/// 
			///	so, 1/x is in
			///		[ 1/ (10^n-1), 1/ (10^(n-1) ) ]
			///
			///  or :
			///		( 1/ 10^n, 1/ (10^(n-1) ) ]
			///  or :
			///		(  10^ -n, 10^ -(n-1)  ]
			///		
			///
			///  but how many n-wide numbers are there?
			///
			///  it's :
			///		9*10^(n-1)
			///		
			/// so for the sum:
			/// it's between:
			///		9* 10^ (n-1)
			///			*
			///		(  10^ -n, 10^ -(n-1)  ]
			///	= 		
			///		( 9* 10^ -1 ,   9* 1 ]
			///	= 		
			///		( 9/10 ,   9 ]
			///


			for (int wide = 1; wide < int.MaxValue; wide++)
			{


			}

		}
	}
}
