﻿using FluentAssertions;
using NUnit.Framework;

namespace JunityTeam.TDDByExample.TheMoneyProblem.Tests
{
    public class MoneyTests
    {
        [Test]
        public void FiveTimesTwo()
        {
            Dollar five = new Dollar();
            five.Times(2).Should().Be(5 * 2);
        }
        
        [Test]
        public void FiveTimesTen()
        {
            Dollar five = new Dollar();
            five.Times(10).Should().Be(5 * 10);
        }
    }
}