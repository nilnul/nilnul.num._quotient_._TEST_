using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._quotient_._TEST_.equation_
{
	class Class1
	{
		public Class1()
		{
			var x = new nilnul.num.quotient.Var();
			var m = new nilnul.num.quotient.Var();
			var n = new nilnul.num.quotient.Var();
			var exprLeft =  nilnul.num.quotient.expr_.call_.Binary.OvDiv(11,x
				
			);

			var exprRight = nilnul.num.quotient.expr_.call_.Binary.OvAdd(
				 nilnul.num.quotient.expr_.call_.Binary.OvDiv(1,m
				),
				 nilnul.num.quotient.expr_.call_.Binary.OvDiv(1,m
				)

			);

			var equation = new nilnul.num.quotient.Equation(
				exprLeft,exprRight
			);
		}
	}
}
