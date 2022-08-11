namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class WasRun : TestCase
    {
        public bool TestWasRun { get; private set; }
        public bool WasSetUp { get; private set; }

        public WasRun(string name) : base(name)
        {
            TestWasRun = false;
            WasSetUp = false;
        }

        public override void SetUp()
        {
            WasSetUp = true;
        }
        
        public void TestMethod()
        {
            TestWasRun = true;
        }
    }
}