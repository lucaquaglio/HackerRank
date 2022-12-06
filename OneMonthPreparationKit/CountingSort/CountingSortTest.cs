using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.CountingSort.Testing
{
	sealed class CountingSortTest
	{
		[Test]
		public void Sort()
		{
			var input = new[] { 1, 1, 3, 2, 1 }.ToList();
			var result = CountingSort.Sort(input);

			var expectedResult = new[] { 0, 3, 1, 1, }.ToList();
			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}