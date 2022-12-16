using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.Testing
{
	sealed class FlippingBitsTest
	{
		[Test]
		public void FlippingBits_Case1()
		{
			var n = 2147483647;

			var result = FlippingBits.Flips(n);
			Assert.That(result, Is.EqualTo(2147483648));
		}

		[Test]
		public void FlippingBits_Case2()
		{
			var n = 1;

			var result = FlippingBits.Flips(n);
			Assert.That(result, Is.EqualTo(4294967294));
		}

		[Test]
		public void FlippingBits_Case3()
		{
			var n = 0;

			var result = FlippingBits.Flips(n);
			Assert.That(result, Is.EqualTo(4294967295));
		}

		[Test]
		public void FlippingBits_Case4()
		{
			var n = 4294967295;

			var result = FlippingBits.Flips(n);
			Assert.That(result, Is.EqualTo(0));
		}
	}
}