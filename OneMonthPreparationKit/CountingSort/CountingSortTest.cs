using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.CountingSort.Testing
{
	sealed class CountingSortTest
	{
		[Test]
		public void Sort()
		{
			var countingSort = new CountingSort();
			var input = new[] { 1, 1, 3, 2, 1 }.ToList();
			var result = countingSort.Sort(input);

			var expectedResult = new[] { 1, 1, 1, 2, 3 }.ToList();
			Assert.That(result, Is.EqualTo(expectedResult));
		}
	}
}