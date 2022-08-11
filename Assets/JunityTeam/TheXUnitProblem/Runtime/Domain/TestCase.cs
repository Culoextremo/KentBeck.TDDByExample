using System;

namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
{
    public abstract class TestCase
    {
        public readonly string Name;
        protected TestCase(string name)
        {
            Name = name;
        }

        public abstract void SetUp();

        public TestResult Run()
        {
            SetUp();
            var result = new TestResult();
            result.TestStarted();
            try
            {
                var method = GetType().GetMethod(Name);
                method.Invoke(this, null);
            }
            catch (Exception e)
            {
                result.TestFailed();
                throw;
            }

            TearDown();
            return result;
        }

        public abstract void TearDown();
        
    }
}