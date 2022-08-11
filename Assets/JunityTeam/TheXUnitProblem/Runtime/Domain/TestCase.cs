﻿namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain
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
            var method = GetType().GetMethod(Name);
            method.Invoke(this, null);
            TearDown();
            return new TestResult();
        }

        public abstract void TearDown();
        
    }
}