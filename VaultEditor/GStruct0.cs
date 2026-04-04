using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public readonly struct GStruct0(int int_1) : IEquatable<GStruct0>
{
    public readonly int int_0 = int_1;

    public static GStruct0 smethod_0()
    {
        return new GStruct0((int)Class14.smethod_1(uint.MaxValue));
    }

    public static GStruct0 smethod_1(string string_0)
    {
        return new GStruct0(int.Parse(string_0, NumberStyles.AllowHexSpecifier));
    }

    public static GStruct0 smethod_2(string string_0, IFormatProvider iformatProvider_0)
    {
        return new GStruct0(int.Parse(string_0, NumberStyles.AllowHexSpecifier, iformatProvider_0));
    }

    public override string ToString()
    {
        return int_0.ToString("x8");
    }

    public string method_0(IFormatProvider iformatProvider_0)
    {
        return int_0.ToString("x8", iformatProvider_0);
    }

    public override int GetHashCode()
    {
        return int_0;
    }

    public override bool Equals(object obj)
    {
        if (obj is GStruct0)
        {
            return ((GStruct0)obj).int_0 == int_0;
        }
        return false;
    }

    public bool Equals(GStruct0 other)
    {
        return int_0 == other.int_0;
    }

    [SpecialName]
    public static bool smethod_3(GStruct0 gstruct0_0, GStruct0 gstruct0_1)
    {
        return gstruct0_0.int_0 == gstruct0_1.int_0;
    }

    [SpecialName]
    public static bool smethod_4(GStruct0 gstruct0_0, GStruct0 gstruct0_1)
    {
        return gstruct0_0.int_0 != gstruct0_1.int_0;
    }
}
