﻿namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Frank : Money
    {
        public Frank(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money Times(int multiplier)
        {
            return Money.Frank(amount * multiplier);
        }
    }
}