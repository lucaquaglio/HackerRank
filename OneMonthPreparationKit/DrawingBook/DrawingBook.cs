namespace HackerRank.OneMonthPreparationKit
{
	sealed class DrawingBook
	{
		public static int PageCount(int n, int p)
		{
			var flippedPagesLtR = p / 2;
			var flippedPagesRtL = (n / 2) - (p / 2);

			return Math.Min(flippedPagesLtR, flippedPagesRtL);
		}
	}
}