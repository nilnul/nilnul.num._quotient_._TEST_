using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;

namespace nilnul.num.quotient.stream_._p_per_TriangularMulti
{
	public class Take : nilnul.num.quotient.stream.Take
	{
		public Take( NumI count) : base(new nilnul.num.quotient.stream_.P_per_TriangularMulti(), count)
		{
		}
	}
}
