using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Numerics;

namespace nilnul.num._quotient_._TEST_.ask.ans_.movingTarget
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{

			/// Ask#:
			/// along an axis with integer readings (in other words, the axis is indexer)
			/// at round 0, a target is at a reading. the reading may be 0, -3, or 1230, or any integer.
			/// each round, the target moving a step positively (towards positive infinity).
			///
			/// now as a shooter, blindfolded, you give order to a bot gun, and let it shoot at some integer. A judge will tell you whether the bot has had shot the target or not.
			///
			/// How can you ensure you has the target shot at some round?
			///

			///Ans#:
			/// construe a cartesian plane where y, being the position of the target., is of integer readings, and X-axis, being the round, is of only natural number reading .; yAxis is
			///      Note: we don't need the negative x-axis here.
			/// 
			/// if the initial position of the target is:
			///		integer I,
			///	then at round x, the position of the target is:
			///		y=i+x
			///
			/// Supposing You shot target at round <var>m</var>.
			///	and your strategy for shooting is:
			///		y=
			///			(3x+1)/2 if x is odd,
			///			x/2 if x is even.
			///		note here, your shot will at one time at the line of (3x+1)/2, at next time at the line of x/2. so in the plot, the shot's finaly place bounds between the two lines alternatively.
			///		and the y(n) is a stream of natural numbers, moving up and down alternatively.
			///		for 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
			///			0, 2, 1, 5, 2, 8, 3, 11,4, 14,5,  17 
			/// the lowerbound of y-tail (after t, where t>=0) is growing. x/2 is moving positvely at a speed lower than target, whileas (3x+1)/2 is moving positively at a speed faster than target.
			///		x/2 will wait for the target to be shot if the target is initially at a nonpositve position.
			///		(3x+1) /2 will catch up with the target if the target is intially at  a position that is positive.
			///  solve the intersection point of
			///		y=i+x
			///
			///		y= (x is odd)?  (3x+1)/2 : x/2
			///
			///		where y=i+x must intersect with either (3x+1)/2, or x/2. dependent on the value of i.
			///			if i is nonpositive, intersection is on x/2
			///				i=x/2
			///					x=-2i
			///			if i is positive, intersection is on (3x+1)/2
			///				i= 1/2+ x/2
			///					 x= 2i-1
			///		for example,
			///			if i is	0, intersection's x is 0
			///					-3, 6round, shot 3
			///					-2, 4round, shot 2
			///					-1, 2round, shot 1
			///					0,0round, shot 0
			///					1, 1round, shot 2
			///					2, 3round, shot 5
			///					3, 5round, shot 8
			///					4, 7round, shot 11
			///							
			/// 
			/// 


			///ans#another:
			/// round0, shot 0, so if target is initally at 0, it will be shot
			/// 
			/// if target is intially at 1, it will be shot, if we at round 1 aim at 1(intial)+1(round)
			/// if target is intially at -1, it will be shot, if we at round 2 aim at -1(intial)+2(round)
			/// 
			/// if target is initially at 2, it will be shot, if we at round 3 aim at 2+3
			/// 
			/// if target is initially at -2, it will be shot, if we at round 4 aim at -2+4
			///
			/// 
			/// if target is intially at n, it will be shot,
			///					if we at round (some odd number r), let a=(r+1)/2,  aim at  a +r
			///									r+1,			 aim at:  -a + (r+1)
			///
			///					at round 2n+1, where n>=0,  aim at   (n+1) + (2n+1) =3n+2
			///						let x=2n+1, y=3n+2, we get y=(3x+1)/2
			///					at round 2n+2,				aim at -(n+1)+ (2n+2) = n+1
			///						let x=2n+2, y=n+1, we get y=x/2
			///
			///				
			///
			///		in other words, at round x, aim at
			///			(3x+1) /2 if x is odd
			///			x/2	 if x is even
			///	we got the same as the first answer.
			///

			///ans#2
			/*假设蚂蚁不动，先打0，再1，然后-1，然后2,-2,…就一定能打到蚂蚁。

			0,  1, -1, 2, -2, 3, -3, …
  
蚂蚁每秒正向移动1，所有上述所有数值 + 秒数t就是打枪顺序。
  
0 + 0,  1 + 1, -1 + 2, 2 + 3, -2 + 4, 3 + 5, -3 + 6, …
			*/

			var rounds = new nilnul.num.stream_.slider_.Nat();
			var linger = new nilnul.num.integer.stream_.slider_.alt_.natural.Subsume();

		

			var aims = new nilnul.num.integer.stream_.slider.op_.binary_._add.Ret(
				linger,

				rounds
			);

			var strCount = 100;

			var stred =  nilnul.obj.stream._FetchX.Fetch(aims, 100);

			Func<BigInteger,BigInteger> func = (BigInteger r) => r % 2 == 0 ? r / 2 : (3 * r + 1) / 2;

			var stream = new nilnul.num.integer.stream_.slider_.OfFunc(func);

			var stred2 = nilnul.obj.stream._FetchX.Fetch(stream, 100);

			Debug.WriteLine(
				nilnul.objs._PhraseX._Phrase(stred2)
			);

			Debug.Assert(
				nilnul.objs.Eq1<BigInteger>.Singleton.Equals(
					stred
					,
					stred2
				)
			);
			


		}
	}
}
/*

升级版：已知数轴上有两只蚂蚁，初始位置在某个整数刻度上，移动速度为每秒+1刻度和每秒-1刻度。观察者每秒可以向数轴的整数位置开一枪。
  
求设计一个开枪策略，确保能打中这两只倒霉的蚂蚁。
  
  
升级版二：已知数轴上有n只蚂蚁，每只的移动速度为v[1],v[2],...v[n]，其余条件相同。求设计开枪策略。
--------------

这个跟原来的比没难度啊，只要能打到正向那只，打到以后，再以相反的移动策略打另外一只，不停类推即可。



 */
