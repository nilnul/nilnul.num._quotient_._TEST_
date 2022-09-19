using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Q1 = nilnul.num.QuotientI;


namespace nilnul.num.quotient.stream_._p_per_TriangularMulti.take
{
	/// <summary>
	/// term can be transformed to : 2*(  1/ k(k-1) - 1/k(k+1) )
	/// </summary>
	public class Sum
	{

		static public Q1 Eval(int i) {
			return nilnul.num.quotient.str._SumX.Sum(
				new nilnul.num.quotient.stream_._p_per_TriangularMulti.Take(new nilnul.Num(i) )
			);
		}



	}
}
