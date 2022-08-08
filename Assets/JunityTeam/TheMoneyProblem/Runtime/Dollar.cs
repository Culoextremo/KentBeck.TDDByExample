namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Dollar
    {
        private int amount;
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public int Times(int multiplier)
        {
            return amount * multiplier;
        }
    }
}