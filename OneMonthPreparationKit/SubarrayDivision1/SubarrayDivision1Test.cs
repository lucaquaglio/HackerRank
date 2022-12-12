using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.SubarrayDivision1.Testing
{
	sealed class SubarrayDivision1Test
	{
		[Test]
		public void Birthday_Case1()
		{
			var chocolateBar = new[] { 2, 2, 1, 3, 2 }.ToList();
			var day = 4;
			var month = 2;

			var result = SubarrayDivision1.Birthday(chocolateBar, day, month);
			Assert.That(result, Is.EqualTo(2));
		}

		[Test]
		public void Birthday_Case2()
		{
			var chocolateBar = new[] { 2, 2, 1, 3, 2 }.ToList();
			var day = 6;
			var month = 3;

			var result = SubarrayDivision1.Birthday(chocolateBar, day, month);
			Assert.That(result, Is.EqualTo(3));
		}

		[Test]
		public void Birthday_Case3()
		{
			var chocolateBar = new[] { 4 }.ToList();
			var day = 4;
			var month = 1;

			var result = SubarrayDivision1.Birthday(chocolateBar, day, month);
			Assert.That(result, Is.EqualTo(2));
		}
	}
}