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

        public void Multiplication(int value, int multiplier)
        {
            Dollar dollar = new Dollar(value);
            dollar.Times(multiplier).amount.Should().Be(value * multiplier);
        }

        [Test]
        public void FiveDollarsEqualFiveDollars()
        {
            new Dollar(5).Should().Be(new Dollar(5));
        }
        
        [Test]
        public void FiveTimesTwoThenSameFiveTimesTwo()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            product.amount.Should().Be(10);
            product = five.Times(2);
            product.amount.Should().Be(10);
        }
    }
}