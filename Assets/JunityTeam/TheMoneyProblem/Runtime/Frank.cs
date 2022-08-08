namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Frank : Money
    {
        public Frank(int amount, string currency)
        {
            this.amount = amount;
            Currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Frank(amount * multiplier);
        }
    }
}