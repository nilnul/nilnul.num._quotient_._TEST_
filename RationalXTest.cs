using nilnul.num.rational;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace nilnul.num.rational.Test
{
    
    
    /// <summary>
    ///This is a test class for RationalXTest and is intended
    ///to contain all RationalXTest Unit Tests
    ///</summary>
	[TestClass()]
	public class RationalXTest
	{


		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		// 
		//You can use the following additional attributes as you write your tests:
		//
		//Use ClassInitialize to run code before running the first test in the class
		//[ClassInitialize()]
		//public static void MyClassInitialize(TestContext testContext)
		//{
		//}
		//
		//Use ClassCleanup to run code after all tests in a class have run
		//[ClassCleanup()]
		//public static void MyClassCleanup()
		//{
		//}
		//
		//Use TestInitialize to run code before running each test
		//[TestInitialize()]
		//public void MyTestInitialize()
		//{
		//}
		//
		//Use TestCleanup to run code after each test has run
		//[TestCleanup()]
		//public void MyTestCleanup()
		//{
		//}
		//
		#endregion


		/// <summary>
		///A test for Parse
		///</summary>
		[TestMethod()]
		public void ParseTest()
		{
			string s ="1"; // TODO: Initialize to an appropriate value
			RationalI expected = new BigInt(1); // TODO: Initialize to an appropriate value
			RationalI actual;
			actual = RationalX.Parse(s);

			Assert.IsTrue(RationalX.Eq(actual, expected));
			


			string s2 = "1/3"; // TODO: Initialize to an appropriate value
			RationalI expected2 = new Fraction__LazyValidated(1,3); // TODO: Initialize to an appropriate value
			RationalI actual2;
			actual2 = RationalX.Parse(s2);

			Assert.IsTrue(RationalX.Eq(actual2, expected2));

			//string s3 = "1.5"; // TODO: Initialize to an appropriate value
			//RationalI expected3 = new Fraction__LazyValidated(1, 3); // TODO: Initialize to an appropriate value
			//RationalI actual3;
			//actual3 = RationalX.Parse(s3);

			//Assert.IsTrue(RationalX.Eq(actual3, expected3));


			Assert.Inconclusive("Verify the correctness of this test method.");



		}
	}
}
