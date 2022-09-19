using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.obj;
using System.Diagnostics;

namespace nilnul.num._quotient_._TEST_.ask.ans
{
	/// <summary>
	/// 1-9填入3*3方格中，每格不同。请问：每行之和，每列之和都是奇数的概率（最简真分数） 的分子和分母之和为多少
	/// </summary>
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var list = new int[9];
			for (int i = 0; i < 9; i++)
			{
				list[i] = i + 1;
			}
			var permutated = nilnul.set.family.op_.of_.set_.permutate_._ByLoopX.Permutate(
				list
			//,
			//EqualityComparer<int>.Default

			);

			var permutated2Arry = permutated.ToArray();
			var oked = permutated.Where(
				x => be(x)
			).ToArray();
			var q = nilnul.num.Quotient1.CreateByDivide(oked.Count(), permutated.Count());
			Debug.WriteLine(q);
			Debug.WriteLine(q.numerator + q.denominator1);
			Debug.Assert(
				q== Quotient1.CreateUnit(14)
			);
		}
		public bool be(int[,] matrix)
		{
			return nilnul.obj._MatrixX.Rows(matrix).All(r => nilnul.num.be_._OddX._AssumeNum(r.Sum()))
				&&
				nilnul.obj._MatrixX.Cols(matrix).All(r => nilnul.num.be_._OddX._AssumeNum(r.Sum()));
		}

		private bool be(int[] x)
		{
			var m = new int[3, 3];

			for (int i = 0; i < x.Length; i++)
			{
				var row = i / 3;
				m[row, i - row * 3] = x[i];
			}
			return be(m);

		}

		private bool be(nilnul.obj.sortie_.OvSeq<int> x)
		{
			var m = new int[3, 3];

			for (int i = 0; i < x.ee.Count(); i++)
			{
				var row = i / 3;
				m[row, i - row * 3] = x.ee.ElementAt(i);
			}
			return be(m);
		}




	}
}
