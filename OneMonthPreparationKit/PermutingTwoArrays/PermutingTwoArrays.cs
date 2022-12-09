namespace HackerRank.OneMonthPreparationKit
{
	sealed class PermutingTwoArrays
	{
		public static string TwoArrays(int k, List<int> A, List<int> B)
		{
			B.Sort();
			foreach (var itemA in A)
			{
				var itemB = B.FirstOrDefault(x => x >= (k - itemA));
				B.Remove(itemB);
			}

			return B.Count == 0
				? "YES"
				: "NO";
		}
	}
}