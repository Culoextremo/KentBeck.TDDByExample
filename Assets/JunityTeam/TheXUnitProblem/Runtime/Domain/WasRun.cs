namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class WasRun
    {
        public bool TestWasRun { get; private set; }
        public WasRun(string name)
        {
            TestWasRun = false;
        }

        public void TestMethod()
        {
            TestWasRun = true;
        }
    }
}