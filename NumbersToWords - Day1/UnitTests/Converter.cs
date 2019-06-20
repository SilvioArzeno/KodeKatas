using NumbersToWords;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ConverterTests
    {

        Converter test = new Converter();
        [Test]
        public void Converter_ToWords_WithZero_ShouldReturnStringZero()
        {
            int input = 0;
            string expected = "Zero";
            Assert.AreEqual(expected,test.ToWords(input));
        }

        [Test]
        public void Converter_ToWords_WithNumbersFromZeroToTen_ShouldReturnAllNumbersFromOneToTen()
        {
            string[] ExpectedOutputs = new string[] {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten" };
            for(int input = 0; input <= 10; input++)
            {
                string expected = ExpectedOutputs[input];
                Assert.AreEqual(expected, test.ToWords(input));
            }
        }

        [Test]

        public void Converter_ToWords_GivenLargeNumber_ShouldReturnExpectedResult()
        {
            int input = 10000;
            string expected = "Ten Thousand";
            Assert.AreEqual(expected, test.ToWords(input));
        }
    }
}
