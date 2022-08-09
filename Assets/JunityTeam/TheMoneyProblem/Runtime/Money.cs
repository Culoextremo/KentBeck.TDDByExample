namespace JunityTeam.TDDByExample.TheMoneyProblem
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

        public Money Reduce(Bank bank, string to)
        {
            int rate = bank.Rate(Currency, to);
            
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