namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(to);
        }

        public void AddRate(string chf, string usd, int i)
        {
            
        }
    }
}