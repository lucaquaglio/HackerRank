namespace HackerRank.OneMonthPreparationKit
{
	sealed class CaesarCipher
	{
		public static string Encrypt(string s, int k)
		{
			var alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
			var alphabetUpper = alphabet.Select(x => char.ToUpper(x)).ToList();

			var result = new List<char>();
			foreach (var c in s)
			{
				var actualAlphabet = char.IsUpper(c)
					? alphabetUpper
					: alphabet;

				if (!actualAlphabet.Contains(c))
				{
					result.Add(c);
					continue;
				}

				var index = (actualAlphabet.IndexOf(c) + k) % actualAlphabet.Count;
				result.Add(actualAlphabet[index]);
			}

			return new string(result.ToArray());
		}
	}
}