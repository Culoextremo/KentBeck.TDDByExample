namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Money : Expression
    {
        protected int amount;
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

        public Money Plus(Money addend)
        {
            return new Money(amount + addend.amount, Currency);
        }
    }
}