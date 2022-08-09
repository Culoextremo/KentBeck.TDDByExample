namespace JunityTeam.TDDByExample.TheMoneyProblem
{
    public class Sum : Expression
    {
        public Money augend;
        public Money addend;

        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.amount + addend.amount;
            return new Money(amount, to);
        }
    }
}