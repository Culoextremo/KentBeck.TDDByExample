namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public abstract class Money
    {
        protected int amount;

        public override bool Equals(object obj)
        {
            var money = (Money) obj;
            return money.amount == amount && money.GetType() == GetType();
        }

        public abstract string Currency();
        
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