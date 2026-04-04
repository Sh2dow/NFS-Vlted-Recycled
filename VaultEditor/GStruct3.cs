using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public readonly struct GStruct3 : IEquatable<GStruct3>
{
    private readonly int int_0;

    private readonly int int_1;

    public static GStruct3 GStruct3_0 => default;

    public bool Boolean_0 => int_0 == 0;

    public int Int32_0
    {
        get
        {
            if (Boolean_0)
            {
                throw new InvalidOperationException();
            }
            return ~int_0;
        }
    }

    public int Int32_1
    {
        get
        {
            if (Boolean_0)
            {
                throw new InvalidOperationException();
            }
            return int_1;
        }
    }

    public GStruct3(int int_2, int int_3)
    {
        if (int_2 < 0)
        {
            throw new ArgumentOutOfRangeException("sectionIndex");
        }
        if (int_3 < 0)
        {
            throw new ArgumentOutOfRangeException("streamIndex");
        }
        int_0 = ~int_2;
        int_1 = int_3;
    }

    public override string ToString()
    {
        if (Boolean_0)
        {
            return "{DecodedStreamIndex Undefined}";
        }
        return $"{{DecodedStreamIndex Section={Int32_0} Stream={Int32_1}}}";
    }

    public override int GetHashCode()
    {
        return (int_0 << 16) + int_1;
    }

    public override bool Equals(object obj)
    {
        if (obj is GStruct3)
        {
            return Equals((GStruct3)obj);
        }
        return false;
    }

    public bool Equals(GStruct3 other)
    {
        if (int_0 == other.int_0)
        {
            return int_1 == other.int_1;
        }
        return false;
    }

    [SpecialName]
    public static bool smethod_0(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
    {
        return gstruct3_0.Equals(gstruct3_1);
    }

    [SpecialName]
    public static bool smethod_1(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
    {
        return !gstruct3_0.Equals(gstruct3_1);
    }
}
