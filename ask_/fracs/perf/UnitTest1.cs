using System;
using System.Diagnostics;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q = nilnul.num._quotient.Dividing;

namespace nilnul.num._quotient_._TEST_.ask_.fracs.perf
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			PerformanceCounter counter = new PerformanceCounter();
			var stopwatch = new Stopwatch();
			
			stopwatch.Start();
			for (BigInteger a = 1;a<=100 ; a++)
			{
				for (BigInteger b = 1; b <= a; b++)
				{
					for (BigInteger c = 1; c <= b; c++)
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
			stopwatch.Stop();
			Debug.WriteLine(stopwatch.ElapsedTicks ); /// 100 nanoseconds; *10 , us
			Debug.WriteLine(stopwatch.ElapsedTicks*100 ); ///  nanoseconds; 
			Debug.WriteLine(stopwatch.ElapsedTicks*100 /1000 ); ///  microseconds; 

			Debug.WriteLine(stopwatch.ElapsedTicks /10d / 1000000); //microseconds per round
			Debug.WriteLine(stopwatch.ElapsedMilliseconds );

			Debug.WriteLine(stopwatch.ElapsedMilliseconds / 1000000d);
		}
	}
}