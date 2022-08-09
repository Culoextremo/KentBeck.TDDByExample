﻿namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Money : Expression
    {
        public int amount;
        public string Currency { get; protected set; }
        
        public Money(int amount, string currency)
        {
            this.amount = amount;
            Currency = currency;
        }
        
        public override bool Equals(object obj)
        {
            var money = (Money) obj;
            return money.amount == amount && money.Currency == Currency;
        }

        public Money Reduce(string to)
        {
            int rate = Currency.Equals("CHF") && to.Equals("USD") ? 2 : 1;
            
            return new Money(amount / rate , to);
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }
        
        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, Currency);
        }

        public Expression Plus(Money addend)
        {
            return new Sum(this, addend);
        }
    }
}