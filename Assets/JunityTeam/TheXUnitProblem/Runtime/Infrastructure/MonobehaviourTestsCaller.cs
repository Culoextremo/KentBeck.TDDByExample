using JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain;
using UnityEngine;
using FluentAssertions;

namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Infrastructure
{
    public class MonobehaviourTestsCaller : MonoBehaviour
    {
        private void Start()
        {
            var test = new WasRun("TestMethod");
            test.TestWasRun.Should().Be(false);
            test.Run();
            test.TestWasRun.Should().Be(true);
        }
    }
}