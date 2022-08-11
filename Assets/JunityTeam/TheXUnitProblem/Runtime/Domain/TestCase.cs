namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class TestCase
    {
        public readonly string Name;
        protected TestCase(string name)
        {
            Name = name;
        }

        public virtual void SetUp()
        {
            
        }
        
        public void Run()
        {
            SetUp();
            var method = GetType().GetMethod(Name);
            method.Invoke(this, null);
        }
    }
}