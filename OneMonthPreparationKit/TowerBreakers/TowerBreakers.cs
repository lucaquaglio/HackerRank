namespace HackerRank.OneMonthPreparationKit
{
	sealed class TowerBreakers
	{
		public static int Play(int n, int m)
		{
			return m != 1 && n % 2 == 1 ? 1 : 2;
		}
	}
}