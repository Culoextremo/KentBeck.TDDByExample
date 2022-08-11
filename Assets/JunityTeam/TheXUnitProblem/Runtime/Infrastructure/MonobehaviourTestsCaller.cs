using JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain;
using UnityEngine;
using FluentAssertions;

namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Infrastructure
{
    public class MonobehaviourTestsCaller : MonoBehaviour
    {
        private WasRun test;
        
        private void Start()
        {
            SetUp();
            TestTemplateMethod();
        }

        private void SetUp()
        {
        }

        private void TestTemplateMethod()
        {
            var test = new WasRun("TestMethod");
            test.Run();
            test.Log.Should().Be("SetUp TestMethod TearDown ");
        }
    }
}