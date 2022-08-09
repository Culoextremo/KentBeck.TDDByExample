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
        public void MultiplicationFrancs(int value, int multiplier)
        {
            Money franc = Money.Franc(value);
            franc.Times(multiplier).Should().Be(Money.Franc(value * multiplier));
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
        public void FiveFrancsNotEqualsTenFrancs()
        {
            Money.Franc(5).Should().NotBe(Money.Franc(10));
        }

        [Test]
        public void FiveFrancsNotEqualToFiveDollars()
        {
            Money.Franc(5).Should().NotBe(Money.Dollar(5));
        }

        [Test]
        public void DollarHasCorrectCurrency()
        {
            "USD".Should().Be(Money.Dollar(1).Currency);
        }
        
        [Test]
        public void FrancHasCorrectCurrency()
        {
            "CHF".Should().Be(Money.Franc(1).Currency);
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