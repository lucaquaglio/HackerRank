namespace HackerRank.OneMonthPreparationKit
{
	sealed class FlippingBits
	{
		public static long Flips(long n)
		{
			return ~Convert.ToUInt32(n);
		}
	}
}