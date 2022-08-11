namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class TestCase
    {
        public readonly string Name;
        protected TestCase(string name)
        {
            Name = name;
        }
        
        public void Run()
        {
            var method = GetType().GetMethod(Name);
            method.Invoke(this, null);
        }
    }
}