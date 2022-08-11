using JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain;
using UnityEngine;
using FluentAssertions;

namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Infrastructure
{
    public class MonobehaviourTestsCaller : MonoBehaviour
    {
        private void Start()
        {
            TestCaseTest();
            TestSetup();
        }

        private void TestSetup()
        {
            var test = new WasRun("TestMethod");
            test.Run();
            test.WasSetUp.Should().Be(true);
        }
        
        private void TestCaseTest()
        {
            var test = new WasRun("TestMethod");
            test.Run();
            test.TestWasRun.Should().Be(true);
        }
    }
}