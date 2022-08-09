namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public interface Expression
    {
        public Money Reduce(Bank bank, string to);
        Expression Plus(Expression tenFrancs);
        Expression Times(int amount);

    }
}