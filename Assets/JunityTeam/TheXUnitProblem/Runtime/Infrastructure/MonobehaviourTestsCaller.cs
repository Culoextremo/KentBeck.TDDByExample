using System;
using JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Domain;
using UnityEngine;

namespace JunityTeam.TDDByExample.TheXUnitProblem.Runtime.Infrastructure
{
    public class MonobehaviourTestsCaller : MonoBehaviour
    {
        private void Start()
        {
            var test = new WasRun("TestMethod");
            Debug.Log(test.TestWasRun);
            test.Run();
            Debug.Log(test.TestWasRun);
        }
    }
}