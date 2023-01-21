using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit
{
	sealed class CaesarCipherTest
	{
		[Test]
		public void Test1()
		{
			var input = "middle-Outz";
			var result = CaesarCipher.Encrypt(input, 2);

			Assert.That(result, Is.EqualTo("okffng-Qwvb"));
		}

		[Test]
		public void Test2()
		{
			var input = "Always-Look-on-the-Bright-Side-of-Life";
			var result = CaesarCipher.Encrypt(input, 5);

			Assert.That(result, Is.EqualTo("Fqbfdx-Qttp-ts-ymj-Gwnlmy-Xnij-tk-Qnkj"));
		}
	}
}