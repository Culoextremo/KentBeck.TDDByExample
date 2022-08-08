namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Dollar
    {
        private int amount;
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var dollar = (Dollar) obj;
            return dollar.amount == amount;
        }
    }
}