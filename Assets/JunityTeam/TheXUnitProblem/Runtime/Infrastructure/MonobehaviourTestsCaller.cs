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
            Setup();
            TestCaseTest();
            TestSetup();
        }

        private void Setup()
        {
            test = new WasRun("TestMethod");
        }

        private void TestSetup()
        {
            test.Run();
            test.WasSetUp.Should().Be(true);
        }
        
        private void TestCaseTest()
        {
            test.Run();
            test.TestWasRun.Should().Be(true);
        }
    }
}