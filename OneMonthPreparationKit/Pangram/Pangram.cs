namespace HackerRank.OneMonthPreparationKit.Pangram
{
	sealed class Pangram
	{
		public static string IsPangram(string s)
		{
			var englishAlphabetList = englishAlphabet.ToList();
			foreach (var letter in s.ToLower().ToArray())
			{
				englishAlphabetList.Remove(letter);
			}

			return englishAlphabetList.Count is 0
				? PangramResult
				: NotPangram;
		}

		static readonly char[] englishAlphabet = new [] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

		const string PangramResult = "pangram";
		const string NotPangram = "not pangram";
	}
}