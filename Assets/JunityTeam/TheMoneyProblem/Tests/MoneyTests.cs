using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace JunityTeam.TDDByExample.TheMoneyProblem.Tests
{
    public class MoneyTests
    {
        [Test]
        [TestCase(5, 2)]
        [TestCase(2, 5)]
        [TestCase(10, 20)]
        public void MultiplicationFrancs(int value, int multiplier)
        {
            Money franc = Money.Franc(value);
            franc.Times(multiplier).Should().Be(Money.Franc(value * multiplier));
        }
        
        [Test]
        [TestCase(5, 2)]
        [TestCase(2, 5)]
        [TestCase(10, 20)]
        public void MultiplicationDollars(int value, int multiplier)
        {
            Money dollar = Money.Dollar(value);
            dollar.Times(multiplier).Should().Be(Money.Dollar(value * multiplier));
        }

        [Test]
        public void TestSimpleAdition()
        {
            Money five = Money.Dollar(5);
            Expression sum = five.Plus(five);
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            reduced.Should().Be(Money.Dollar(10));
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
        public void SumIsCorrect()
        {
            Money one = Money.Dollar(1);
            Money five = Money.Dollar(5);

            Expression result = one.Plus(five);
            Sum sum = (Sum) result;
            
            sum.augend.Should().Be(one);
            sum.addend.Should().Be(five);
        }

        [Test]
        public void TestBankReduceSum()
        {
            Expression sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            Bank bank = new Bank();
            Money result = bank.Reduce(sum, "USD");
            result.Should().Be(Money.Dollar(7));
        }

        [Test]
        public void TestReduceMoney()
        {
            Bank bank = new Bank();
            Money result = bank.Reduce(Money.Dollar(1), "USD");
            result.Should().Be(Money.Dollar(1));
        }

        [Test]
        public void ReduceMoneyDifferentCurrency()
        {
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(Money.Franc(2), "USD");
            result.Should().Be(Money.Dollar(1));
        }

        [Test]
        public void MixedAddition()
        {
            Expression fiveDollars = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Money result = bank.Reduce(fiveDollars.Plus(tenFrancs), "USD");
            result.Should().Be(Money.Dollar(10));
        }

        [Test]
        public void TestSumPlusMoney()
        {
            Expression fiveDollars = Money.Dollar(5);
            Expression tenFrancs = Money.Franc(10);
            Bank bank = new Bank();
            bank.AddRate("CHF", "USD", 2);
            Expression sum = new Sum(fiveDollars, tenFrancs).Plus(fiveDollars);
            Money result = bank.Reduce(sum, "USD");
            result.Should().Be(Money.Dollar(15));
        }

        [Test]
        public void TestIdentityRate()
        {
            new Bank().Rate("USD", "USD").Should().Be(1);
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