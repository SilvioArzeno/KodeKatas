using NUnit.Framework;
using SortingItOut;
using System;
using System.Collections.Generic;

namespace SortingItOutTests
{
    [TestFixture]
    public class SortingTests
    {
        [Test]
        public void Balls_GivenEmptyBallsList_ShouldReturnEmptyArray()
        {
            int[] test = new int[] { };
             Rack rack= new Rack(test);
            Assert.AreEqual( new int[] { } , Rack.Balls(rack));
        }
        [Test]
        public void Balls_GivenUnsortedBallsList_ShouldReturnSortedList()
        {
            int[] test = new int[] { 25,12,8,9,45};
            int[] expected = new int[] { 8, 9, 12, 25, 45 };
            Rack rack = new Rack(test);
            Assert.AreEqual(expected, Rack.Balls(rack));
        }

        [Test]
        public void Balls_GivenBallsInDifferentOrder_ShouldReturnSortedList()
        {
            
            Rack rack = new Rack(new int[] { });
            rack.balls.Add(15);
            Assert.AreEqual(new int[] { 15 }, Rack.Balls(rack));
            rack.balls.Add(18);
            Assert.AreEqual(new int[] { 15 , 18 }, Rack.Balls(rack));
            rack.balls.Add(5);
            Assert.AreEqual(new int[] { 5, 15, 18 }, Rack.Balls(rack));
            rack.balls.Add(1);
            Assert.AreEqual(new int[] { 1,5,15,18 }, Rack.Balls(rack));
            rack.balls.Add(29);
            Assert.AreEqual(new int[] { 1, 5, 15, 18,29 }, Rack.Balls(rack));

        }



    }
}
