using System;

namespace VaultEditor;

public sealed class GAttribute1 : Attribute
{
    public string Name { get; set; }

    public bool ReadOnly { get; set; }

    public GEnum20 DataType { get; set; }

    public GAttribute1(string string_0)
    {
        Name = string_0;
        ReadOnly = false;
    }

    public GAttribute1()
    {
        Name = "Value";
        ReadOnly = false;
    }
}
