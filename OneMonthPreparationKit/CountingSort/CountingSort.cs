namespace HackerRank.OneMonthPreparationKit.CountingSort
{
	sealed class CountingSort
	{
		public static List<int> Sort(List<int> arr)
		{
			var frequencyArray = new int[100];

			for (int i = 0; i < arr.Count; i++)
			{
				var countingIndex = arr[i];
				frequencyArray[countingIndex]++;
			}

			return frequencyArray.ToList();
		}
	}
}