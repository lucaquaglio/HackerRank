using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.Testing
{
	class ZigZagSequenceTest
	{
		[Test]
		public void Scenario1()
		{
			var input = new int[] { 2, 3, 5, 1, 4 }.ToList();
			var result = ZigZagSequence.FindZigZagSequence(input, input.Count);

			Assert.That(result, Is.EqualTo(new int[] { 1, 4, 5, 3, 2 }));
		}

		[Test]
		public void Scenario2()
		{
			var input = new int[] { 1, 2, 3, 4, 5, 6, 7 }.ToList();

			var result = ZigZagSequence.FindZigZagSequence(input, input.Count);

			Assert.That(result, Is.EqualTo(new int[] { 1, 2, 3, 7, 6, 5, 4, }));
		}
	}
}