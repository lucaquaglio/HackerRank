namespace HackerRank.OneMonthPreparationKit.SubarrayDivision1
{
	sealed class SubarrayDivision1
	{
		public static int Birthday(List<int> s, int d, int m)
		{
			var squares = s;
			var n = squares.Count;

			int ct = 0;
			int sum = 0;

			for (int i = 0; i < m - 1; i++)
			{
				sum += squares[i];
			}

			for (int j = m - 1; j < n; j++)
			{
				sum -= (j - m) < 0 ? 0 : squares[j - m];
				sum += squares[j];
				if (sum == d)
					ct++;
			}

			return ct;
		}
	}
}