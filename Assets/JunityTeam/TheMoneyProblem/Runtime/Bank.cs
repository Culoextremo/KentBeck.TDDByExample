using System.Collections;
using System.Collections.Generic;

namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Bank
    {
        private Dictionary<(string,string), int> rates;

        public Bank()
        {
            rates = new Dictionary<(string,string), int>();
        }
        
        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string source, string target, int rate)
        {
            rates.Add((source, target), rate);
        }

        public int Rate(string from, string to)
        {
            if (from == to) return 1;
            int rate = rates[(from, to)];
            return rate;
        }
    }
}