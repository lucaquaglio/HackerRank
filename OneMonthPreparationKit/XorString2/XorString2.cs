namespace HackerRank.OneMonthPreparationKit
{
	sealed class XorString2
	{
		public static string StringXOR(string s, string t)
		{
			var res = string.Empty;
			for (int i = 0; i < s.Length; i++)
			{
				res += Xor(i);
			}

			return res;

			string Xor(int index)
			{
				return s[index] == t[index]
					? "0"
					: "1";
			}
		}
	}
}