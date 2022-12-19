using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.Testing
{
	sealed class SalesByMatchTest
	{
		[Test]
		public void Scenario1()
		{
			var input = new int[] { 1, 2, 1, 2, 1, 3, 2 }.ToList();

			var result = SalesByMatch.SockMerchant(input.Count, input);
			Assert.That(result, Is.EqualTo(2));
		}

		[Test]
		public void Scenario2()
		{
			var input = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }.ToList();
			var result = SalesByMatch.SockMerchant(input.Count, input);
			Assert.That(result, Is.EqualTo(3));
		}
	}
}