namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Frank : Money
    {
        public Frank(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Frank(amount * multiplier);
        }
    }
}