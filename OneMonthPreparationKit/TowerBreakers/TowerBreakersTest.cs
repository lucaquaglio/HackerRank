using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit
{
	sealed class TowerBreakersTest
	{
		[Test]
		public void Scenario1()
		{
			var numberOfTowers = 2;
			var lenghtOfTowers = 6;

			var winner = TowerBreakers.Play(numberOfTowers, lenghtOfTowers);

			Assert.That(winner, Is.EqualTo(2));
		}

		[Test]
		public void Scenario2()
		{
			var numberOfTowers = 2;
			var lenghtOfTowers = 2;

			var winner = TowerBreakers.Play(numberOfTowers, lenghtOfTowers);

			Assert.That(winner, Is.EqualTo(2));
		}

		[Test]
		public void Scenario3()
		{
			var numberOfTowers = 1;
			var lenghtOfTowers = 4;

			var winner = TowerBreakers.Play(numberOfTowers, lenghtOfTowers);

			Assert.That(winner, Is.EqualTo(1));
		}
	}
}