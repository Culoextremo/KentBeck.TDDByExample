namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            Sum sum = (Sum) source;
            int amount = sum.augend.amount + sum.addend.amount;
            return new Money(amount, to);
        }
    }
}