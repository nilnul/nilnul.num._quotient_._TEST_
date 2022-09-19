using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;


using Q1 = nilnul.num.QuotientI;
using nilnul.num.quotient;
using nilnul.obj._slider_;

namespace nilnul.num.quotient.stream_
{
	public class P_per_TriangularMulti
		:nilnul.num.quotient.SliderI1
		,
		nilnul.num.quotient.StreamI4
	{

		private nilnul.num.stream_.plural.Slider _plural=new nilnul.num.stream_.plural.Slider();

		public nilnul.num.stream_.plural.Slider plural
		{
			get { return _plural; }
			//set { _plural = value; }
		}

		private nilnul.num.stream_.triangular.adjacentMulti.Slider _triangularAdjacentMulti=new nilnul.num.stream_.triangular.adjacentMulti.Slider();
		public nilnul.num.stream_.triangular.adjacentMulti.Slider triangularAdjacentMulti
		{
			get { return _triangularAdjacentMulti; }
			//set { _triangularAdjacentMulti = value; }
		}

		public Q1 current
		{
			get
			{
				return new nilnul.num.Quotient(
					_plural.current
					,
					_triangularAdjacentMulti.current
				);
				//throw new NotImplementedException();
			}
		}

		

		public P_per_TriangularMulti()
		{
			_triangularAdjacentMulti.moveNext();
		}

		public void moveNext()
		{
			_plural.moveNext();
			_triangularAdjacentMulti.moveNext();

			//throw new NotImplementedException();
		}

		public Q1 next()
		{
			var oldCurrent = current;
			moveNext();
			return oldCurrent;

		}
	}
}
