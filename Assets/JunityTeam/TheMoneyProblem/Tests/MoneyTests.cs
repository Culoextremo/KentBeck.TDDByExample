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
            five.Times(2).Should().Be(five.amount * 2);
        }
        
        [Test]
        public void FiveTimesTen()
        {
            Dollar five = new Dollar(5);
            five.Times(10).Should().Be(five.amount * 10);
        }

        [Test]
        public void TenTimesTwenty()
        {
            Dollar ten = new Dollar(10);
            ten.Times(20).Should().Be(ten.amount * 20);
        }
    }
}