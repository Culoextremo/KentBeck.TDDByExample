namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public interface Expression
    {
        public Money Reduce(string to);
    }
}