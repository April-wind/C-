using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AttributeUsage(AttributeTargets.Class,Inherited = false)]//定制特性适用范围 
public class CustomAttribute : System.Attribute
{
    private string name;
    public CustomAttribute(string name)
    {
        this.name = name;
    }
}
