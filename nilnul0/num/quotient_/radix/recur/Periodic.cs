using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using R = nilnul.num.rational.Rational_InheritFraction2;
using System.Diagnostics;

namespace nilnul.num.rational._test.float_
{
	[TestClass]
	public class Periodic
	{
		[TestMethod]
		public void Periodic_Test()
		{
			var biCycle = new nilnul.num.rational.float_.Periodic(
				2, 
				nilnul.num.natural.Radix1.Binary.Singleton.Instance.parse( "1101"), 
				-4, 
				3);

			var rational = biCycle.toRational();

		}

		[TestMethod]
		public void Periodic_tobased() {
			var a = nilnul.num.rational.float_.Periodic.FroRational(2, 
				new nilnul.num.rational.Rational_InheritFraction2(1,10));

			var b = nilnul.num.rational.float_.based.binary.Periodic.FroRational(

				new R(6,7)

				
			);
		
		}


		[TestMethod]
		public void Recur_toTxt() {
			_recur_toTxt(1, 10, "0.1");
			_recur_toTxt(1, 3, "0.(3");

			_recur_toTxt(7, 6, "1.1(6");





		
		}

		public void _recur_toTxt(int a, int b,string target) {

			//var recur = nilnul.num.quotient.radix.recur.Dec.FroQuotient(1, 10);

			Debug.Assert(
				nilnul.num.quotient.radix.recur.Dec.FroQuotient(a,b).ToString()==
				target
			);


		}




	}
}
