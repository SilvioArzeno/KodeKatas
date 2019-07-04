using NUnit.Framework;
using RangesAgain;
using System;

namespace RangesTests
{
    [TestFixture]
    public class ProjectTests
    {
        [Test]
        public void RangesContain_GivenRangeFrom2Throught6AndFrom2Throught4_ShouldReturnTrue()
        {
            Range range = new Range("[2,6)");
            Assert.AreEqual(true, range.Contains("[2,4]"));
        }
        [Test]
        public void RangesContain_GivenRangeFrom2Throught6AndFrom6Throught9_ShouldReturnFalse()
        {
            Range range = new Range("[2,6)");
            Assert.AreEqual(false, range.Contains("[6,9)"));
        }

        [Test]
        public void RangesGetAllPoints_GivenRangeFrom2Thought6_ShouldReturnExpectedOutput()
        {
            Range range = new Range("[2,6)");
            string expected = "{2,3,4,5}";
            Assert.AreEqual(expected, range.GetAllPoints());
        }
        [Test]
        public void RangeEndPoints_GivenRangeFrom2Thought6_ShouldReturn2and5()
        {
            Range range = new Range("[2,6)");
            string expected = "{2,5}";
            Assert.AreEqual(expected, range.EndPoints());
        }

        [Test]
        public void RangeOverlapsRange_GivenTwoOverlappingRanges_ShouldReturnTrue()
        {
            Range range1 = new Range("[2,5)");
            Range range2 = new Range("[3,9)");
            Assert.AreEqual(true, range1.Overlaps(range2));
        }

    }
}
