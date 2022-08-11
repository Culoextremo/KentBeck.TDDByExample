namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public class TestResult
    {
        public string Summary => RunCount + " run, " + ErrorCount + " failed";

        public int RunCount { get; private set; }
        public int ErrorCount { get; private set; }

        public TestResult()
        {
            RunCount = 0;
        }

        public void TestStarted()
        {
            RunCount++;
        }


        public void TestFailed()
        {
            ErrorCount++;
        }
    }
}