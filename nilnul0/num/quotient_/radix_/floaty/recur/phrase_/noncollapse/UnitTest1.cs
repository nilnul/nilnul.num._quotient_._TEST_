using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;
using F = nilnul.num.quotient_.radix_.floaty.Recur;
using R = nilnul.num.quotient_.nonneg_.radix_.floaty.Recur;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix_.floaty.recur.phrase_.noncollapse
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var r = new F(
				new R(
					10
					,
					new BigInteger[] { }
					,
					0
					,
					0
				)
				,
				false
			);

			v(r, "0");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] { }
					,
					0
					,
					0
				)
				,
				true
			);

			v(r, "-0");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] { 0}
					,
					0
					,
					0
				)
				,
				true
			);
			v(r, "-0");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] { 0}
					,
					0
					,
					1
				)
				,
				true
			);
			v(r, "-(0");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0, 0}
					,
					0
					,
					1
				)
				,
				true
			);
			v(r, "-0(0");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0, 0}
					,
					0
					,
					1
				)
				,
				false
			);
			v(r, "0(0");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0, 0}
					,
					-1
					,
					1
				)
				,
				false
			);
			v(r, "0.(0");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0, 0}
					,
					-2
					,
					1
				)
				,
				false
			);
			v(r, "0.0(0");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0, 0,0}
					,
					-2
					,
					1
				)
				,
				false
			);
			v(r, "0.0(0");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-2
					,
					0
				)
				,
				false
			);
			v(r, "3.21");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-2
					,
					1
				)
				,
				false
			);
			v(r, "3.2(1");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-2
					,0
				)
				,
				true
			);
			v(r, "-3.21");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-2
					,3
				)
				,
				true
			);
			v(r, "-(3.21");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-3
					,0
				)
				,
				false
			);
			v(r, "0.321");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-3
					,1
				)
				,
				false
			);
			v(r, "0.32(1");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					-3
					,3
				)
				,
				false
			);
			v(r, "0.(321");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 ,0}
					,
					-3
					,0
				)
				,
				true
			);
			v(r, "-0.321");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 ,0}
					,
					-3
					,1
				)
				,
				true
			);
			v(r, "-0.32(1");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 ,0}
					,
					-3
					,4
				)
				,
				true
			);
			v(r, "-(0.321");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 ,0}
					,
					-3
					,4
				)
				
			);
			v(r, "(0.321");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					0
					,0
				)
				,
				false
			);
			v(r, "321");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {1,2,3 }
					,
					0
					,
					3
				)
				,
				true
			);

			v(r, "-(321");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0,1,2,3 }
					,
					0
					,2
				)
				,
				true
			);
			v(r, "-32(10");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0,1,2,3,0 }
					,
					0
					,2
				)
				,
				true
			);
			v(r, "-032(10");



			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0,1,2,3,0 }
					,
					0
					,0
				)
				,
				true
			);
			v(r, "-03210");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0,1,2,3,0,0 }
					,
					-5
					,
					5
				)
				,
				true
			);
			v(r, "-0.(03210");


			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0,1,2,3,0 }
					,
					-5
					,
					5
				)
				,
				true
			);
			v(r, "-0.(03210");

			 r = new F(
				new R(
					10
					,
					new BigInteger[] {0,1,2,3,0 }
					,
					-5
					,
					4
				)
				,
				true
			);
			v(r, "-0.0(3210");

		}

		void v(F x, string expected) {
			Assert.IsTrue(


				x.phrase8noncollapse() == expected
			);
		}


	}
}
