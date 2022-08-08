namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
            Currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}