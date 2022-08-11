namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class TestResult
    {
        public string Summary => RunCount + " run, 0 failed";

        public int RunCount { get; private set; }
        public TestResult()
        {
            RunCount = 0;
        }

        public void TestStarted()
        {
            RunCount++;
        }


    }
}