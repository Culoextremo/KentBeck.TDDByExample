namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency)
        {
            this.amount = amount;
            Currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(amount * multiplier);
        }
    }
}