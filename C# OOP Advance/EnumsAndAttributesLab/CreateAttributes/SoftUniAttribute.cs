﻿
using System;public class SoftUniAttribute : Attribute
{
    public SoftUniAttribute(string name)
    {
        this.Name = name;
    }
    public string Name { get; set; }    
}
