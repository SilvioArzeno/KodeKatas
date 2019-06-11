using Anagram;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace AnagramTests
{
    [TestFixture]
    public class AnagramTests
    {
        Anagrams test = new Anagrams();

        [Test]
        public void Anagrams_LoadWords_WithNonExistingDirectory_ShouldThrowDirectoryNotFoundException()
        {
            string NonExistingDirectory = @"MarkZuckeberg/Wallet";
            Assert.Throws(typeof(DirectoryNotFoundException), delegate { test.LoadWords(NonExistingDirectory); });
        }
        [Test]
        public void Anagrams_LoadWords_WithNonExistingFile_ShouldThrowFileNotFoundException()
        {
            string NonExistingFile = @"C:\Users\Silvio Arzeno\Desktop\Anagram Tests\MoneyOnMyWallet.txt";
            Assert.Throws(typeof(FileNotFoundException), delegate { test.LoadWords(NonExistingFile); });
        }
        [Test]
        public void Anagrams_LoadWords_WithEmptyFile_ShouldThrowEmptyFileException()
        {
            string EmptyFile = @"C:\Users\Silvio Arzeno\Desktop\Anagram Tests\Empty File.txt";
            Assert.Throws(typeof(EmptyFileException), delegate { test.LoadWords(EmptyFile); });
        }

        [Test]

        public void Anagrams_LoadWords_WithTestCase1_ShouldReturnAnArrayWithAllTheWordsInTheFile()
        {
            string TestCase1 = @"C:\Users\Silvio Arzeno\Desktop\Anagram Tests\TestCase1.txt";
            int ExpectedLength = 16;
            test.LoadWords(TestCase1);
            Assert.That(test.LoadedWords.Length == ExpectedLength);
        }

        [Test]
        public void Anagrams_FindAllAnagrams_WithTestCase1_ShouldReturnExpectedResult()
        {
            Dictionary<string, string[]> ExpectedResult = new Dictionary<string, string[]>();
            ExpectedResult.Add("fresher", new string[] { "refresh" });
            Assert.AreEqual(ExpectedResult, test.FindAllAnagrams());
        }
    }
}
