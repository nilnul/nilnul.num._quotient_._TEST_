using System;
using System.Diagnostics;
using System.Numerics;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q = nilnul.num._quotient.Dividing;

namespace nilnul.num._quotient_._TEST_.ask_.fracs.verify.big
{
	[TestClass]
	public class UnitTest111
	{
		[TestMethod]
		public void TestMethod1()
		{
			string clean(string s) {
				return Regex.Replace(s, " |\r|\n|\t|_", "");
				//return s.Replace(" ", "").Replace("\r", "").Replace("\n", "").Replace("_","").Replace("\t","");
			}

			BigInteger a = BigInteger.Parse(
				clean(
				@"

16666476865438449865846131095313531540647604679654766832109616387367203990642764342248100534807579493874453954854925352739900051220936419971671875594417036870073291371





"
				)
			);

			BigInteger b = BigInteger.Parse(
				clean(
				@"
					184386514670723295219914666691038096275031765336404340516686430257803895506237580602582859039981257570380161221662398153794290821569045182385603418867509209632768359835



				"
				)
			);

			BigInteger c = BigInteger.Parse(
				clean(
				@"
					
32343421153825592353880655285224263330451946573450847101645239147091638517651250940206853612606768544181415355352136077327300271806129063833025389772729796460799697289
				"
				)
			);

			//var gcd = BigInteger.GreatestCommonDivisor()
			Debug.Assert(
				new Q(a, b + c)
					+
				new Q(b, c + a)
					+
				new Q(c, a + b) == 4
			);
		}
	}
}