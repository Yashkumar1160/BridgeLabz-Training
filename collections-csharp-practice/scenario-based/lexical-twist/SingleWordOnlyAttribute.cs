using System;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.lexical_twist
{
    //custom annotation to mark single-word validation
    [AttributeUsage(AttributeTargets.Method)]
    internal class SingleWordOnlyAttribute : Attribute
    {
    }
}
