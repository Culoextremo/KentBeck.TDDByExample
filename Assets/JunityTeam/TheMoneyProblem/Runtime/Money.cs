namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public abstract class Money
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
            return money.amount == amount && money.GetType() == GetType();
        }
        
        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }
        
        public static Money Frank(int amount)
        {
            return new Frank(amount, "CHF");
        }

        public abstract Money Times(int multiplier);
        
    }
}