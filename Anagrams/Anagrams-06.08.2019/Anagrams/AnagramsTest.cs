
using AnagramsKatas;
using NUnit.Framework;
using System.IO;

namespace Anagrams
{
    [TestFixture]
    public class AnagramsTest
    {
        Anagram test = new Anagram();
        [Test]
        public void AnagramLoadWords_GivenNonExistentFile_ShouldThrowFileNotFoundException()
        {
            string NonExistingPath = @"C:\Users\Silvio Arzeno\Desktop\HelloWorld!";
            Assert.Throws(typeof(FileNotFoundException), delegate { test.LoadWords(NonExistingPath); });

        }

        [Test]

        public void AnagramLoadWords_GivenEmptyFile_ShouldThrowEmptyFileException()
        {
            string EmptyFilePath = @"C:\Users\Silvio Arzeno\Desktop\Anagram Tests\Empty File.txt";
            Assert.Throws(typeof(Anagram.EmptyFileException), delegate { test.LoadWords(EmptyFilePath); });
            
        }
    }
}
