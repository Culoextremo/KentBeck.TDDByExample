namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class WasRun : TestCase
    {
        public string Log { get; private set; }

        public WasRun(string name) : base(name)
        {
        }

        public override void SetUp()
        {
            Log = "SetUp ";
        }
        
        public void TestMethod()
        {
            Log += "TestMethod ";
        }

        public override void TearDown()
        {
            Log += "TearDown ";
        }
    }
}