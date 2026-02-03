using System;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.flip_key
{
    //custom annotation to define validation rule
    [AttributeUsage(AttributeTargets.Method)]
    internal class FlipKeyAttribute : Attribute
    {
        public string Pattern { get; }

        //constructor to accept regex pattern
        public FlipKeyAttribute(string pattern)
        {
            Pattern = pattern;
        }
    }
}
