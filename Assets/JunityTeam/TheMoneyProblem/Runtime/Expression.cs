namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public interface Expression
    {
        public Money Reduce(Bank bank, string to);
    }
}