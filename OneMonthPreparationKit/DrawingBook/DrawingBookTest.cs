using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.Testing
{
	sealed class DrawingBookTest
	{
		[Test]
		public void Scenario1()
		{
			var n = 5;
			var p = 3;

			var result = DrawingBook.PageCount(n, p);
			Assert.That(result, Is.EqualTo(1));
		}

		[Test]
		public void Scenario2()
		{
			var n = 6;
			var p = 5;

			var result = DrawingBook.PageCount(n, p);
			Assert.That(result, Is.EqualTo(1));
		}
	}
}