using NUnit.Framework;

namespace HackerRank.OneMonthPreparationKit.Pangram.Testing
{
	sealed class PangramTest
	{
		[Test]
		public void IsPangram()
		{
			var result = Pangram.IsPangram("We promptly judged antique ivory buckles for the next prize");
			Assert.That(result, Is.EqualTo("pangram"));

			result = Pangram.IsPangram("All of the letters of the alphabet are present in the string.");
			Assert.That(result, Is.EqualTo("not pangram"));
		}
	}
}