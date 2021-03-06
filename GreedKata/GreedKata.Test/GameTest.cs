using GreedKata;
using NUnit.Framework;
using System;

namespace Tests
{
    public class GameTest
    {
        Game greed;
        [SetUp]
        public void Setup()
        {
            greed = new Game();
        }

        [Test]
        public void SingleOne100PointsScenario1()
        {
            int actual = greed.RollDice(DiceValue.One, DiceValue.Two, DiceValue.Three, DiceValue.Four, DiceValue.Four, DiceValue.Six);
            int expected = 100;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SingleOne100PointsSingleFive50PointsScenario()
        {
            int actual = greed.RollDice(DiceValue.One, DiceValue.Five, DiceValue.Three, DiceValue.Three, DiceValue.Four, DiceValue.Six);
            int expected = 150;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SingleOne100PointsScenario2()
        {
            int actual = greed.RollDice(DiceValue.One, DiceValue.Two, DiceValue.One, DiceValue.Four, DiceValue.One, DiceValue.Six);
            int expected = 1000;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void NoSingleScenarioMetScoresZero()
        {
            int actual = greed.RollDice(DiceValue.Two, DiceValue.Two, DiceValue.Three, DiceValue.Four, DiceValue.Three, DiceValue.Six);
            int expected = 0;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SingleFive50PointsScenario1()
        {
            int actual = greed.RollDice(DiceValue.Five, DiceValue.Two, DiceValue.Three, DiceValue.Four, DiceValue.Three, DiceValue.Six);
            int expected = 50;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void SingleFive50PointsScenario2()
        {
            int actual = greed.RollDice(DiceValue.Five, DiceValue.Five, DiceValue.Three, DiceValue.Four, DiceValue.Three, DiceValue.Six);
            int expected = 100;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleOne1000PointsScenario1()
        {
            int actual = greed.RollDice(DiceValue.One, DiceValue.One, DiceValue.One, DiceValue.Four, DiceValue.Three, DiceValue.Six);
            int expected = 1000;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleOne1000PointsScenario2()
        {
            int actual = greed.RollDice(DiceValue.One, DiceValue.One, DiceValue.One, DiceValue.One, DiceValue.Three, DiceValue.Six);
            int expected = 1100;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TripleOne1000PointsScenario3()
        {
            int actual = greed.RollDice(DiceValue.One, DiceValue.One, DiceValue.One, DiceValue.One, DiceValue.One, DiceValue.One);
            int expected = 2000;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleOne1000PointsScenario4()
        {
            int actual = greed.RollDice(DiceValue.One, DiceValue.One, DiceValue.One, DiceValue.One, DiceValue.Three, DiceValue.Five);
            int expected = 1150;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleTwo200PointsScenario1()
        {
            int actual = greed.RollDice(DiceValue.Two, DiceValue.Two, DiceValue.Two, DiceValue.Four, DiceValue.Three, DiceValue.Six);
            int expected = 200;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleTwo200PointsScenario2()
        {
            int actual = greed.RollDice(DiceValue.Two, DiceValue.Two, DiceValue.Two, DiceValue.Two, DiceValue.Two, DiceValue.Two);
            int expected = 400;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleTwo200PointsScenario3()
        {
            int actual = greed.RollDice(DiceValue.Two, DiceValue.Two, DiceValue.Two, DiceValue.Five, DiceValue.Two, DiceValue.Two);
            int expected = 250;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TripleTwoAndOneScenario()
        {
            int actual = greed.RollDice(DiceValue.Two, DiceValue.Two, DiceValue.Two, DiceValue.One, DiceValue.One, DiceValue.One);
            int expected = 1200;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void TripleThree300PointsScenario1()
        {
            int actual = greed.RollDice(DiceValue.Three, DiceValue.Three, DiceValue.Three, DiceValue.Four, DiceValue.Three, DiceValue.Six);
            int expected = 300;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleThree300PointsScenario2()
        {
            int actual = greed.RollDice(DiceValue.Three, DiceValue.Three, DiceValue.Three, DiceValue.Three, DiceValue.Three, DiceValue.Three);
            int expected = 600;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleThree300PointsScenario3()
        {
            int actual = greed.RollDice(DiceValue.Three, DiceValue.Three, DiceValue.Three, DiceValue.Four, DiceValue.One, DiceValue.Five);
            int expected = 450;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TripleFour400PointsScenario1()
        {
            int actual = greed.RollDice(DiceValue.Four, DiceValue.Four, DiceValue.Four, DiceValue.Four, DiceValue.Three, DiceValue.Six);
            int expected = 400;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleFour400PointsScenario2()
        {
            int actual = greed.RollDice(DiceValue.Four, DiceValue.Four, DiceValue.Four, DiceValue.Four, DiceValue.Four, DiceValue.Four);
            int expected = 800;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleFour400PointsScenario3()
        {
            int actual = greed.RollDice(DiceValue.Four, DiceValue.Four, DiceValue.Four, DiceValue.Four, DiceValue.One, DiceValue.Five);
            int expected = 550;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TripleFive500PointsScenario1()
        {
            int actual = greed.RollDice(DiceValue.Five, DiceValue.Five, DiceValue.Five, DiceValue.Four, DiceValue.Three, DiceValue.Six);
            int expected = 500;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleFive500PointsScenario2()
        {
            int actual = greed.RollDice(DiceValue.Five, DiceValue.Five, DiceValue.Five, DiceValue.Five, DiceValue.Five, DiceValue.Five);
            int expected = 1000;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleFive500PointsScenario3()
        {
            int actual = greed.RollDice(DiceValue.Five, DiceValue.Five, DiceValue.Five, DiceValue.Four, DiceValue.One, DiceValue.Five);
            int expected = 650;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleSix600PointsScenario1()
        {
            int actual = greed.RollDice(DiceValue.Six, DiceValue.Six, DiceValue.Six, DiceValue.Four, DiceValue.Three, DiceValue.Three);
            int expected = 600;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleSix600PointsScenario2()
        {
            int actual = greed.RollDice(DiceValue.Six, DiceValue.Six, DiceValue.Six, DiceValue.Six, DiceValue.Six, DiceValue.Six);
            int expected = 1200;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TripleSix600PointsScenario3()
        {
            int actual = greed.RollDice(DiceValue.Six, DiceValue.Six, DiceValue.Six, DiceValue.Four, DiceValue.One, DiceValue.Five);
            int expected = 750;
            Console.WriteLine($"Expected : {expected}  Actual : {actual}");
            Assert.AreEqual(expected, actual);
        }






    }
}