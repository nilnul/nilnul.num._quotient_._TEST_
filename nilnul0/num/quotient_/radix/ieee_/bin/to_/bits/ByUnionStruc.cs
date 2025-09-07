using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num._quotient_._TEST_.nilnul0.num.quotient_.radix.ext.errable_.ieee_.dbl.to_.bits
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DoubleULong
	{
		[FieldOffset(0)]
		public double Double;

		[FieldOffset(0)]
		public readonly ulong ULong;
	}


	internal class ByUnionStruc
	{
		bool IsNegative(double value)
		{
			var du = new DoubleULong { Double = value };
			return ((du.ULong >> 62) & 2) == 2;
		}
	}
}
