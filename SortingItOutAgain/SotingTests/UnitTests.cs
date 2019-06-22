using NUnit.Framework;
using SortingItOutAgain;
using System;
using System.Collections.Generic;

namespace SotingTests
{
    [TestFixture]
    public class SortingItOutTests
    {
        [Test]
        public void Balls_GivenEmptyListOfBalls_ShouldReturnEmptyArray()
        {
            Rack rack = new Rack();
            rack.balls = new List<int>();
            Assert.AreEqual(rack.balls.ToArray(), rack.Balls());
        }
        
        [Test]
        public void Balls_GivenUnsortedListOfBalls_ShouldReturnSortedArray()
        {

            Rack rack = new Rack(new int[] { 8,12,6,7,25,1});
            int[] expected = new int[] { 1, 6, 7, 8, 12, 25 };
            Assert.AreEqual(expected, rack.Balls());
        }
        [Test]
        public void Balls_GivenBallsAtDifferentOrders_ShouldReturnSortedArrayEachTime()
        {
            int[] expected;
            Rack rack = new Rack();
            rack.balls.Add(10);
            expected = new int[] { 10 };
            Assert.AreEqual(expected, rack.Balls());
            rack.balls.Add(80);
            expected = new int[] { 10 , 80 };
            Assert.AreEqual(expected, rack.Balls());
            rack.balls.Add(1);
            rack.balls.Add(12);
            expected = new int[] { 1,10,12, 80 };
            Assert.AreEqual(expected, rack.Balls());

        }
    }

    [TestFixture]
    public class CharacterSortingTests
    {
        [Test]
        public void SortText_GivenEmptyBlockOfText_ShouldReturnBlank()
        {
            Text text = new Text();
            string sortedText = text.SortLetters();
            Assert.AreEqual("", sortedText);
        }

        [Test]
        public void SortText_GivenInput_ShouldReturnAllTheCharactersInOrder()
        {
            Text text = new Text("When not studying nuclear physics, Bambi likes to play beach volleyball.");
            string sortedText = text.SortLetters();
            Assert.AreEqual("aaaaabbbbcccdeeeeeghhhiiiiklllllllmnnnnooopprsssstttuuvwyyyy", sortedText);
        }
    }
}
