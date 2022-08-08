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
            Frank frank = Money.Frank(value);
            frank.Times(multiplier).Should().Be(Money.Frank(value * multiplier));
        }
        
        [Test]
        [TestCase(5, 2)]
        [TestCase(2, 5)]
        [TestCase(5, 10)]
        [TestCase(10, 20)]
        public void MultiplicationDollars(int value, int multiplier)
        {
            Money dollar = Money.Dollar(value);
            dollar.Times(multiplier).Should().Be(Money.Dollar(value * multiplier));
        }

        [Test]
        public void FiveDollarsEqualFiveDollars()
        {
            Money.Dollar(5).Should().Be(Money.Dollar(5));
        }

        [Test]
        public void FiveDollarsNotEqualsTenDollars()
        {
            Money.Dollar(5).Should().NotBe(Money.Dollar(10));
        }
        
        [Test]
        public void FiveFranksEqualFiveFranks()
        {
            Money.Frank(5).Should().Be(Money.Frank(5));
        }

        [Test]
        public void FiveFranksNotEqualsTenFranks()
        {
            Money.Frank(5).Should().NotBe(Money.Frank(10));
        }

        [Test]
        public void FiveFranksNotEqualToFiveDollars()
        {
            Money.Frank(5).Should().NotBe(Money.Dollar(5));
        }

        [Test]
        public void DollarHasCorrectCurrency()
        {
            "USD".Should().Be(Money.Dollar(1).currency);
        }
        
        [Test]
        public void FrankHasCorrectCurrency()
        {
            "CHF".Should().Be(Money.Frank(1).currency);
        }
        
        [Test]
        public void FiveTimesTwoThenSameFiveTimesTwo()
        {
            Money five = Money.Dollar(5);
            five.Times(2).Should().Be(Money.Dollar(10));
            five.Times(2).Should().Be(Money.Dollar(10));
        }
    }
}