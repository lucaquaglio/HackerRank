using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.Test
{
	sealed class DiagonalDifferenceTest
	{
		[Test]
		public void CalculateDiagonal()
		{
			var input = new List<List<int>>
			{
				new[] { 1, 2, 3 }.ToList(),
				new[] { 4, 5, 6 }.ToList(),
				new[] { 9, 8, 9 }.ToList(),
			};

			var result = DiagonalDifference.CalculateDiagonalDifference(input);
			Assert.AreEqual(2, result);
		}
	}
}