using NUnit.Framework;
using System;

namespace Summator.Tests
{
    public class Tests
    {
        private Summator summator;

        [SetUp]
        public void SetUp()
        {
            summator = new Summator();
            System.Console.WriteLine("Test started: " + DateTime.Now);
        }

        [Test]
        [Category("Sum Method")]
        public void Test_Sum_TwoPositiveNumbers()
        {
            long actual = summator.Sum(new int[] { 5, 7 });
            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        [Category("Sum Method")]
        public void Test_Sum_OnePositiveNumber()
        {
            long actual = summator.Sum(new int[] { 5 });

            Assert.That(actual == 5);
        }

        [Test]
        [Category("Sum Method")]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = summator.Sum(new int[] { -6, -8 });

            Assert.That(actual == -14);
        }

        [Test]
        [Category("Sum Method")]
        public void Test_Sum_EmptyArray()
        {
            long actual = summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }

        [Test]
        [Category("Sum Method")]
        public void Test_Sum_BigValues()
        {
            long actual = summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(6000000000, actual);
        }

        [Test]
        [Category("Average Method")]
        public void Test_Average_TwoPositiveNumbers()
        {
            long actual = Summator.Average(new int[] { 5, 7 });
            int expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("Average Method")]
        public void Test_Average_TwoNegativeNumbers()
        {
            long actual = Summator.Average(new int[] { -3, -5 });

            Assert.That(actual == -4);
        }

        [Test]
        [Category("Average Method")]
        public void Test_Average_BigValues()
        {
            long actual = Summator.Average(arr: new int[] { 200000000, 100000000, 300000000 });

            Assert.AreEqual(200000000, actual);
        }

        [TearDown]
        public void TearDown()
        {
            summator = null;
            System.Console.WriteLine("Test ended: " + DateTime.Now);
        }
    }
}