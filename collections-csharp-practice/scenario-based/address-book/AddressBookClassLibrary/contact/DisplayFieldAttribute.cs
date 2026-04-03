using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//attribute for properties 
[AttributeUsage(AttributeTargets.Property)] 
public class DisplayFieldAttribute : Attribute
{
    public string DisplayName { get; }

    public DisplayFieldAttribute(string displayName)
    {
        DisplayName = displayName;
    }
}
