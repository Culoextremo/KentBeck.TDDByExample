using FluentAssertions;
using NUnit.Framework;

namespace JunityTeam.TDDByExample.TheMoneyProblem.Tests
{
    public class MoneyTests
    {
        [Test]
        [TestCase(5, 2)]
        [TestCase(2, 5)]
        [TestCase(5, 10)]
        [TestCase(10, 20)]
        public void MultiplicationFranks(int value, int multiplier)
        {
            Frank frank = new Frank(value);
            frank.Times(multiplier).Should().Be(new Frank(value * multiplier));
        }
        
        [Test]
        [TestCase(5, 2)]
        [TestCase(2, 5)]
        [TestCase(5, 10)]
        [TestCase(10, 20)]
        public void MultiplicationDollars(int value, int multiplier)
        {
            Dollar dollar = new Dollar(value);
            dollar.Times(multiplier).Should().Be(new Dollar(value * multiplier));
        }

        [Test]
        public void FiveDollarsEqualFiveDollars()
        {
            new Dollar(5).Should().Be(new Dollar(5));
        }

        [Test]
        public void FiveDollarsNotEqualsTenDollars()
        {
            new Dollar(5).Should().NotBe(new Dollar(10));
        }
        
        [Test]
        public void FiveTimesTwoThenSameFiveTimesTwo()
        {
            Dollar five = new Dollar(5);
            five.Times(2).Should().Be(new Dollar(10));
            five.Times(2).Should().Be(new Dollar(10));
        }
    }
}