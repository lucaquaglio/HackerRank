using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit
{
	sealed class PermutingTwoArraysTest
	{
		[Test]
		public void PermuteTwoArrays_ReturnYes()
		{
			var k = 10;
			var a = new[] { 2, 1, 3 }.ToList();
			var b = new[] { 7, 8, 9 }.ToList();

			var result = PermutingTwoArrays.TwoArrays(k, a, b);
			Assert.That(result, Is.EqualTo("YES"));
		}

		[Test]
		public void PermuteTwoArrays_ReturnYes2()
		{
			var k = 4;
			var a = new[] { 4, 4, 3, 2, 1, 4, 4, 3, 2, 4 }.ToList();
			var b = new[] { 2, 3, 0, 1, 1, 3, 1, 0, 0, 2 }.ToList();

			var result = PermutingTwoArrays.TwoArrays(k, a, b);
			Assert.That(result, Is.EqualTo("YES"));
		}

		[Test]
		public void PermuteTwoArrays_ReturnYes3()
		{
			var k = 9;
			var a = new[] { 3, 6, 8, 5, 9, 9, 4, 8, 4, 7 }.ToList();
			var b = new[] { 5, 1, 0, 1, 6, 4, 1, 7, 4, 3, }.ToList();

			var result = PermutingTwoArrays.TwoArrays(k, a, b);
			Assert.That(result, Is.EqualTo("YES"));
		}

		[Test]
		public void PermuteTwoArrays_ReturnYes4()
		{
			var k = 9;
			var a = new[] { 3, 6, 8, 5, 9, 9, 4, 8, 4, 7 }.ToList();
			var b = new[] { 5, 1, 0, 1, 6, 4, 1, 7, 4, 3, }.ToList();

			var result = PermutingTwoArrays.TwoArrays(k, a, b);
			Assert.That(result, Is.EqualTo("YES"));
		}

		[Test]
		public void PermuteTwoArrays_ReturnNo()
		{
			var k = 5;
			var a = new[] { 1, 2, 2, 1 }.ToList();
			var b = new[] { 3, 3, 3, 4 }.ToList();

			var result = PermutingTwoArrays.TwoArrays(k, a, b);
			Assert.That(result, Is.EqualTo("NO"));
		}

		[Test]
		public void PermuteTwoArrays_ReturnNo2()
		{
			var k = 9;
			var a = new[] { 1, 5, 1, 4, 4, 2, 7, 1, 2, 2 }.ToList();
			var b = new[] { 8, 7, 1, 7, 7, 4, 4, 3, 6, 7 }.ToList();

			var result = PermutingTwoArrays.TwoArrays(k, a, b);
			Assert.That(result, Is.EqualTo("NO"));
		}

		[Test]
		public void PermuteTwoArrays_ReturnNo3()
		{
			var k = 5;
			var a = new[] { 2, 3, 1, 1, 1, }.ToList();
			var b = new[] { 1, 3, 4, 3, 3, }.ToList();

			var result = PermutingTwoArrays.TwoArrays(k, a, b);
			Assert.That(result, Is.EqualTo("NO"));
		}
	}
}