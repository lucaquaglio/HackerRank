using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.Test
{
	sealed class DiagonalDifferenceTest
	{
		/*		  
		 * Given a square matrix, calculate the absolute difference between the sums of its diagonals.
		 * For example, the square matrix  is shown below:
		 *		1 2 3
		 *		4 5 6
		 *		9 8 9  
		 * The left-to-right diagonal = 1 + 5 + 9 = 15 The right to left diagonal = 3 + 5 + 9 Their absolute difference is |15-17| = 2
		*/
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