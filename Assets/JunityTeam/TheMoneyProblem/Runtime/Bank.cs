namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            if (source is Money) return (Money) source;
            Sum sum = (Sum) source;
            return sum.Reduce(to);
        }
    }
}