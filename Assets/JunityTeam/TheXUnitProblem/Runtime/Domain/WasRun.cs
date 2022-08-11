namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class WasRun : TestCase
    {
        public bool TestWasRun { get; private set; }
        public string Log { get; private set; }

        public WasRun(string name) : base(name)
        {
            TestWasRun = false;
        }

        public override void SetUp()
        {
            TestWasRun = false;
            Log = "SetUp ";
        }
        
        public void TestMethod()
        {
            TestWasRun = true;
            Log += "TestMethod ";
        }

        public override void TearDown()
        {
            Log += "TearDown ";
        }
    }
}