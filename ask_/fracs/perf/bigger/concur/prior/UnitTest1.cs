using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q = nilnul.num._quotient.Dividing;
using System.Linq.Expressions;
using System.Threading;

namespace nilnul.num._quotient_._TEST_.ask_.fracs.perf.bigger.concur.prior
{
#if TRIAL

	[TestClass]
#endif
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
    Thread.CurrentThread.Priority = ThreadPriority.Highest;
			PerformanceCounter counter = new PerformanceCounter();
			var stopwatch = new Stopwatch();

			IEnumerable<BigInteger> range1(BigInteger y)
			{
				BigInteger x = 1;
				while (x <= y)
				{
					yield return x++;
				}
			}

			stopwatch.Start();

			for (BigInteger a=1; a<=100 ; a++)
			{
				foreach (BigInteger b in range1(a).AsParallel())
				{
					foreach (BigInteger c   in range1(b).AsParallel())
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

			Trace.WriteLine(stopwatch.ElapsedTicks); /// 100 nanoseconds; *10 , us
			Trace.WriteLine(stopwatch.ElapsedTicks * 100); ///  nanoseconds; 
			Trace.WriteLine(stopwatch.ElapsedTicks * 100 / 1000); ///  microseconds; 

			Trace.WriteLine(stopwatch.ElapsedTicks / 10d / 1000000); //microseconds per round
			Trace.WriteLine(stopwatch.ElapsedMilliseconds);

			Trace.WriteLine(stopwatch.ElapsedMilliseconds / 1000000d);

			Trace.WriteLine("---------");
			forBigger();
		}

		public void forBigger()
		{
			PerformanceCounter counter = new PerformanceCounter();
			var stopwatch = new Stopwatch();

			stopwatch.Start();
			BigInteger basis = 10000000;
			BigInteger basisInc = basis + 1;

			for (BigInteger a = basisInc; a <= basis + 100; a++)
			{
				for (BigInteger b = basisInc; b <= a; b++)
				{
					for (BigInteger c = basisInc; c <= b; c++)
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

			Debug.WriteLine(stopwatch.ElapsedTicks); /// 100 nanoseconds; *10 , us
			Debug.WriteLine(stopwatch.ElapsedTicks * 100); ///  nanoseconds; 
			Debug.WriteLine(stopwatch.ElapsedTicks * 100 / 1000); ///  microseconds; 

			Debug.WriteLine(stopwatch.ElapsedTicks / 10d / 1000000); //microseconds per round
			Debug.WriteLine(stopwatch.ElapsedMilliseconds);

			Debug.WriteLine(stopwatch.ElapsedMilliseconds / 1000000d);
		}

	}
}