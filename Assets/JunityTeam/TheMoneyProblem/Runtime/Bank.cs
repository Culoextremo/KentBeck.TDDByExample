namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string chf, string usd, int i)
        {
            
        }

        public int Rate(string from, string to)
        {
            return from.Equals("CHF") && to.Equals("USD") ? 2 : 1;
        }
    }
}