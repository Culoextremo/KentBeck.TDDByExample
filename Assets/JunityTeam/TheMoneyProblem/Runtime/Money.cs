namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Money
    {
        protected int amount;
        
        public override bool Equals(object obj)
        {
            var money = (Money) obj;
            return money.amount == amount && money.GetType() == GetType();
        }
    }
}