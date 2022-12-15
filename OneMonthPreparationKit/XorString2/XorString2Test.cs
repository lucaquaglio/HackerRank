using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.Testing
{
	sealed class XorString2Test
	{
		[Test]
		public void StringXOR_Case1()
		{
			var s = "10101";
			var t = "00101";

			var result = XorString2.StringXOR(s, t);

			Assert.That(result, Is.EqualTo("10000"));
		}


	}
}