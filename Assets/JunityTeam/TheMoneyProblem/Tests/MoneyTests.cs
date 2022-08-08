using FluentAssertions;
using NUnit.Framework;

namespace JunityTeam.TDDByExample.TheMoneyProblem.Tests
{
    public class MoneyTests
    {
        [Test]
        public void FiveTimesTwo()
        {
            Dollar five = new Dollar(5);
            five.Times(2).amount.Should().Be(five.amount * 2);
        }

        [Test]
        public void TwoTimesFive()
        {
            Dollar two = new Dollar(2);
            two.Times(5).amount.Should().Be(two.amount * 5);
        }
        
        [Test]
        public void FiveTimesTen()
        {
            Dollar five = new Dollar(5);
            five.Times(10).amount.Should().Be(five.amount * 10);
        }

        [Test]
        public void TenTimesTwenty()
        {
            Dollar ten = new Dollar(10);
            ten.Times(20).amount.Should().Be(ten.amount * 20);
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