using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.num.quotient._test.matrix.op
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void GaussianRowElimination()
		{

			var matrix = new Q[,] {
				{ 2,1,-1,8}
				, { -3,-1,2,-11}
				, { -2,1,2,-3}

			};

			 nilnul.num.quotient.matrix.op.GaussianEliminationInRows.Eval(matrix);
		}

		[TestMethod]
		public void Inverse()
		{

			var nul = new nilnul.num.quotient.matrix.Square_array();

			var nul_inverse = num.quotient.matrix.square.be.nonSingular.Inverse._Eval(nul);

			Debug.Assert(
				num.quotient.matrix.duo.be.SameDimension.Asserted._Eq(nul_inverse, nul)	
			);

			var one = quotient.matrix.Square_array.CreateIdentityArray(1);

			Debug.Assert(

				num.quotient.matrix.duo.be.SameDimension.Asserted._Eq(
					quotient.matrix.square.be.nonSingular.Inverse._Eval(one)
					
					, one)	
			);


			var i2 = quotient.matrix.Square_array.CreateIdentityArray(2);

			Debug.Assert(

				num.quotient.matrix.duo.be.SameDimension.Asserted._Eq(
					quotient.matrix.square.be.nonSingular.Inverse._Eval(i2)
					
					, i2)	
			);

			var i3 = quotient.matrix.Square_array.CreateIdentityArray(3);

			Debug.Assert(

				num.quotient.matrix.duo.be.SameDimension.Asserted._Eq(
					quotient.matrix.square.be.nonSingular.Inverse._Eval(i3)
					
					, i3)	
			);

			var i4 = quotient.matrix.Square_array.CreateIdentityArray(3);

			Debug.Assert(

				num.quotient.matrix.duo.be.SameDimension.Asserted._Eq(
					quotient.matrix.square.be.nonSingular.Inverse._Eval(i4)
					
					, i4)	
			);






		}
	}
}
