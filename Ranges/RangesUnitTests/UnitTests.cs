using NUnit.Framework;
using Ranges;
using System;

namespace RangesUnitTests
{
    [TestFixture]
    public class RangesTests
    {
        [Test]
        public void RangesContains_GivenRange2Through6AND2Throught4_ShouldReturnTrue()
        {
            Range range = new Range("[2,6)");
            Assert.AreEqual(true, range.Contains("[2,4]"));
        }
        [Test]
        public void RangesContains_GivenRange2Through6AND6Throught8_ShouldReturnFalse()
        {
            Range range = new Range("[2,6)");
            Assert.AreEqual(false, range.Contains("[6,8]"));
        }

    }
}
