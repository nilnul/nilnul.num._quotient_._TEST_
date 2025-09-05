using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.quotient.stream.sub_.monotone.theorem_
{
	/// <summary>
	/// always exists a monotonic subSequence.
	/// </summary>
	/// proof:
	///		suppose there are infinite <see cref="el.be_.Peak"/>
	///		,
	///		then the peaks form a monotonic nonincreasing subsequence.
	///
	///		if there are finite peaks:
	///			let N be the index of the final Peak (N=-1, if there is no peaks at all).
	///			;
	///			; now construct the new subsequence by letting:
	///			 [N+1]. then it's not peak, hence there exists n[1] such that x[n[1]] is greater than x[N+1]. And n[1] is also not peak, hence we can find another element that is greater.
	///			 ; repeatedly, we get a new nondecreasing subsequence.
	internal class BolzanoWeierstrass
	{
	}
}
