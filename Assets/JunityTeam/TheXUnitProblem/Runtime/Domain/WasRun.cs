namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class WasRun
    {
        public bool TestWasRun { get; private set; }
        public readonly string Name;

        public WasRun(string name)
        {
            TestWasRun = false;
            Name = name;
        }

        public void Run()
        {
            var method = GetType().GetMethod(Name);
            method.Invoke(this, null);
        }
        public void TestMethod()
        {
            TestWasRun = true;
        }
    }
}