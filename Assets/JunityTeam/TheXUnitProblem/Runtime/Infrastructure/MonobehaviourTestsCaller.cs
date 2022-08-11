using JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain;
using UnityEngine;
using FluentAssertions;

namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Infrastructure
{
    public class MonobehaviourTestsCaller : MonoBehaviour
    {
        private void Start()
        {
            TestTemplateMethod();
            TestResult();
            TestBrokenMethod();
        }

        private void TestResult()
        {
            var test = new WasRun("TestMethod");
            var result = test.Run();
            result.Summary.Should().Be("1 run, 0 failed");
        }

        private void TestBrokenMethod()
        {
            var test = new WasRun("TestBrokenMethod");
            var result = test.Run();
            result.Summary.Should().Be("1 run, 1 failed");
        }
        
        private void TestTemplateMethod()
        {
            var test = new WasRun("TestMethod");
            test.Run();
            test.Log.Should().Be("SetUp TestMethod TearDown ");
        }
    }
}