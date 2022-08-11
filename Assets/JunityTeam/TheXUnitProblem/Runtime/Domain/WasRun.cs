namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class WasRun : TestCase
    {
        public bool TestWasRun { get; private set; }
        public WasRun(string name) : base(name)
        {
            TestWasRun = false;
        }
        
        public void TestMethod()
        {
            TestWasRun = true;
        }
    }
}