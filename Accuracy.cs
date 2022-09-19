using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nilnul.num.rational;

using Assert1 = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace nilnul.num.rational._test
{
	[TestClass]
	public class Accuracy
	{
		[TestMethod]
		public void Accuracy_test()
		{
			var interval = nilnul.num.rational.Interval2.CreateOpen(-3, 3);

			//var interval2 = nilnul.num.rational.Interval2.CreateOpen(3, -3);

			var interval2 = nilnul.num.rational.Interval2.CreateOpen(3, 4);
			var interval3 = nilnul.num.rational.Interval2.CreateOpen(0, 4);
			var interval4 = nilnul.num.rational.Interval2.CreateClose(0, 4);


			var accuracy = Accuracy2.CreateSymmetricOpen(3);

			var accuracy2 = new Accuracy2(interval4);
			






		}
	}
}
