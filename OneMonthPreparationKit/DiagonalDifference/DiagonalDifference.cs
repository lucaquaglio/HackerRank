namespace HackerRank.OneMonthPreparationKit
{
	internal class DiagonalDifference
	{
		public static int CalculateDiagonalDifference(List<List<int>> arr)
		{
			var diagonalLtR = CalculateDiagonal(arr, DiagonalDirection.LeftoRight);
			var diagonalRtL = CalculateDiagonal(arr, DiagonalDirection.RightToLeft);
			return Math.Abs(diagonalLtR - diagonalRtL);
		}

		static int CalculateDiagonal(List<List<int>> squareMatrix, DiagonalDirection diagonalDirection)
		{
			var diagonal = 0;
			for (int i = 0; i < squareMatrix.Count; i++)
			{
				var row = squareMatrix[i];
				var cell = diagonalDirection is DiagonalDirection.RightToLeft
					? row[i]
					: row[squareMatrix.Count - 1 - i];

				diagonal += cell;
			}
			return diagonal;
		}

		enum DiagonalDirection
		{
			LeftoRight,
			RightToLeft,
		}
	}
}