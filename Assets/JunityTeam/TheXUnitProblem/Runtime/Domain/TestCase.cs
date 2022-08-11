namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public abstract class TestCase
    {
        public readonly string Name;
        protected TestCase(string name)
        {
            Name = name;
        }

        public abstract void SetUp();

        public void Run()
        {
            SetUp();
            var method = GetType().GetMethod(Name);
            method.Invoke(this, null);
            TearDown();
        }

        public abstract void TearDown();
        
    }
}