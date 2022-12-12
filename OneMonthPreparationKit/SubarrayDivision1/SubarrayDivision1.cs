namespace HackerRank.OneMonthPreparationKit.SubarrayDivision1
{
	sealed class SubarrayDivision1
	{
		public static int Birthday(List<int> s, int d, int m)
		{
			var waysToDivideChocolate = new List<string>();
			for (int i = 0; i <= s.Count - m; i++)
			{
				var square = s[i];
				var segments = new Stack<int>();
				segments.Push(square);

				foreach (var squareToAdd in s.Skip(i + 1))
				{
					var squareSum = segments.Sum() + squareToAdd;
					if (squareSum <= d)
					{
						segments.Push(squareToAdd);

						if (segments.Count == m)
						{
							if (squareSum == d)
							{
								waysToDivideChocolate.Add(string.Join(':', segments));
							}
							else
							{
								segments.Pop();
							}
						}
					}
				}
			}

			return waysToDivideChocolate.Distinct().Count();
		}
	}
}