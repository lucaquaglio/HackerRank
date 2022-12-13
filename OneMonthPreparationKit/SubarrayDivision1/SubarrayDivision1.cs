namespace HackerRank.OneMonthPreparationKit.SubarrayDivision1
{
	sealed class SubarrayDivision1
	{
		public static int Birthday(List<int> s, int d, int m)
		{
			var waysBarCanBeDivided = new List<string>();
			for (int i = 0; i < s.Count; i++)
			{
				var segments = new List<int>();
				var square = s[i];

				if (square > d)
				{
					continue;
				}

				segments.Add(square);

				for (int j = i + 1; j < s.Count && segments.Count < m; j++)
				{
					var nextSquare = s[j];
					var squareSum = segments.Sum() + nextSquare;
					if (squareSum > d)
					{
						continue;
					}

					if (segments.Count < (m - 1) || squareSum == d)
					{
						segments.Add(nextSquare);
					}
				}

				if (segments.Sum() == d && segments.Count == m)
				{
					var differenceToMonth = m - segments.Count;
					for (int j = 0; j < differenceToMonth; j++)
					{
						segments.Add(0);
					}

					var way = string.Join(":", segments.OrderBy(x => x).ToArray());
					if (!waysBarCanBeDivided.Contains(way))
					{
						waysBarCanBeDivided.Add(way);
					}
				}
			}

			return waysBarCanBeDivided.Distinct().Count();
		}
	}
}