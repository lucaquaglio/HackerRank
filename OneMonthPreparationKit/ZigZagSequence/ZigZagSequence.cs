namespace HackerRank.OneMonthPreparationKit
{
	sealed class ZigZagSequence
	{
		public static List<int> FindZigZagSequence(List<int> a, int n)
		{
			a.Sort();
			var mid = (n + 1) / 2;
			var temp = a[mid];
			a[mid - 1] = a[n - 1];
			a[n - 1] = temp;

			var st = mid + 1;
			var ed = n - 1;
			while (st < ed)
			{
				temp = a[st];
				a[st] = a[ed];
				a[ed] = temp;
				st++;
				ed--;
			}

			var result = new List<int>();
			for (int i = 0; i < n; i++)
			{
				result.Add(a[i]);
			}
			return result;
		}
	}
}