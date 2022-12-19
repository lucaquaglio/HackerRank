namespace HackerRank.OneMonthPreparationKit
{
	sealed class SalesByMatch
	{
		public static int SockMerchant(int n, List<int> ar)
		{
			var typesOfColors = ar.Distinct();

			var result = 0;
			foreach (var type in typesOfColors)
			{
				var pairOfSocks = ar.Count(x => x == type) / 2;
				result += pairOfSocks;
			}

			return result;
		}
	}
}