namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public abstract class Money
    {
        protected int amount;
        public string Currency { get; protected set; }
        
        public override bool Equals(object obj)
        {
            var money = (Money) obj;
            return money.amount == amount && money.GetType() == GetType();
        }
        
        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }
        
        public static Money Frank(int amount)
        {
            return new Frank(amount);
        }

        public abstract Money Times(int multiplier);
        
    }
}