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

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public abstract Money Times(int multiplier);
        
    }
}