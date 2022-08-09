namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Money
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
            return new Dollar(amount, "USD");
        }
        
        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public virtual Money Times(int multiplier)
        {
            return null;
        }
        
    }
}