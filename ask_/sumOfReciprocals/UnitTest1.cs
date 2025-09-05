using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.bit.str;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace nilnul.num._quotient_._TEST_.ask_.sumOfReciprocals
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			///找到集合，其元素为1到100中的数，使得元素的倒数和为1。
			///

			var one = nilnul.num._quotient.Dividing.One;

			//for (int i = 1; i <= 100; i++)
			//{
			//	sets(i, one);

			//}

			/// {1} is a solution. and any other solution wouldnot contain 1.
			/// , so we skip 1 here.
			///
			var total = 0;

			Enumerable.Range(1, 100).SelectMany(
				i => sets(i, one)
			).Each(
				x => {
					Debug.Write($"{total++}th: ");
					Debug.WriteLine(
									nilnul.obj.set.PhraseX.Phrase(x)
						);


				}
			);//
			  //.ToArray();

			Debug.WriteLine(total);

			//r.Each(s =>
			//	Debug.WriteLine(
			//	nilnul.obj.set.PhraseX.Phrase(s)
			//	)
			//);

			/// return all sets such that for each set:
			///		,the member of which is in [start, 100]
			///		, the sum of reciprocals of each element of which is target
			///		
			static IEnumerable<IEnumerable<int>> sets(

				int start /// plural
				,
				nilnul.num._quotient.Dividing target    /// positive
			)
			{
				//if (start > 100)
				//{
				//	yield break;
				//}

				for (int i = start; i <= 100; i++)
				{
					//var reciprocal = nilnul.num._quotient.Dividing.Reciprocal(i);

					//var set = new List<nilnul.num._quotient.Dividing>() { reciprocal};

					//var set1 = new List<int>() { i };


					var sum =nilnul.num._quotient.Dividing.Reciprocal(i)

					//	set1.Aggregate(
					//	nilnul.num._quotient.Dividing.Nil
					//	,
					//	(a1, c) => a1 + nilnul.num._quotient.Dividing.Reciprocal(c)
					//)
					;

					var delta = target - sum;

					var sign = delta.sign;


	
					if (sign < 0) {
						yield break;
					}

					if (sign ==0)
					{
						yield return new[] { i};
						yield break;
					}

					//if (sum < 1)
					//{


					//if (iPlus <= 100)
					//{

					foreach (var item in sets(i + 1, delta))
						{
							yield return item.Prepend(i);// set1.Concat(item);
						}

					//}


					//}
					//else if (sum == 1)
					//{
					//	yield return set1;
					//}
					//else
					//{
					//	yield break;
					//}

				}

			}

		}
	}
}
