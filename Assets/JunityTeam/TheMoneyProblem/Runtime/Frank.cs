namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Frank
    {
        private int amount;
        public Frank(int amount)
        {
            this.amount = amount;
        }

        public Frank Times(int multiplier)
        {
            return new Frank(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var dollar = (Frank) obj;
            return dollar.amount == amount;
        }
    }
}