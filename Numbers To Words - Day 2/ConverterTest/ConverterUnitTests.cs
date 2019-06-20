
using Numbers_To_Words;
using NUnit.Framework;
using System;

namespace ConverterTest
{
    [TestFixture]
    public class ConverterTest
    {

        Converter test = new Converter();
        [Test]
        public void Converter_ToWords_GivenNumberZero_ShouldReturnZero()
        {
            int input = 0;
            string expected = "Zero";
            Assert.AreEqual(expected, test.ToWords(input));

        }

        [Test]
        public void Converter_ToWords_GivenNumbersFromZeroToNine_ShouldReturnExpectedAnswers()
        {
            string[] ExpectedAnswers = new string[] {"Zero", " One"," Two"," Three"," Four"," Five"," Six"," Seven", " Eight", " Nine"};
            for(int input = 0; input < 10; input++)
            {
                Assert.AreEqual(ExpectedAnswers[input], test.ToWords(input));
            }
        }

        [Test]
        public void Converter_ToWords_GivenLargeNumber_ShouldReturnExpectedResult()
        {
            int input = 10000;
            string expected = " Ten Thousand";
            Assert.AreEqual(expected, test.ToWords(input));
        }
        [Test]
        public void Converter_ToWords_GivenLargeComplexNumbers_ShouldReturnExpectedResult()
        {
            int input = 123456;
            string expected = " One Hundred Twenty Three Thousand Four Hundred Fifty Six";
            Assert.AreEqual(expected, test.ToWords(input));
        }
    }
}
