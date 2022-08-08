﻿namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Dollar : Money
    {
        public string currency = "USD";

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}