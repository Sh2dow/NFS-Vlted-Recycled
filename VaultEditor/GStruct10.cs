using System;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public struct GStruct10(int int_2, int int_3) : IEquatable<GStruct10>
{
    public int int_0 = int_2;

    public int int_1 = int_3;

    public static GStruct10 GStruct10_0 => default;

    public void method_0(int int_2, int int_3)
    {
        int_0 += int_2;
        int_1 += int_3;
    }

    public readonly bool Equals(GStruct10 other)
    {
        if (int_0 == other.int_0)
        {
            return int_1 == other.int_1;
        }
        return false;
    }

    public override bool Equals(object obj)
    {
        if (obj is GStruct10)
        {
            return Equals((GStruct10)obj);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return int_0.GetHashCode() ^ int_1.GetHashCode();
    }

    [SpecialName]
    public static bool smethod_0(GStruct10 gstruct10_0, GStruct10 gstruct10_1)
    {
        return !gstruct10_0.Equals(gstruct10_1);
    }

    [SpecialName]
    public static bool smethod_1(GStruct10 gstruct10_0, GStruct10 gstruct10_1)
    {
        return gstruct10_0.Equals(gstruct10_1);
    }

    [SpecialName]
    public static bool smethod_2(GStruct10 gstruct10_0, GStruct10 gstruct10_1)
    {
        if (gstruct10_0.int_1 < gstruct10_1.int_1)
        {
            return true;
        }
        if (gstruct10_0.int_1 > gstruct10_1.int_1)
        {
            return false;
        }
        if (gstruct10_0.int_0 < gstruct10_1.int_0)
        {
            return true;
        }
        return false;
    }

    [SpecialName]
    public static bool smethod_3(GStruct10 gstruct10_0, GStruct10 gstruct10_1)
    {
        if (gstruct10_0.Equals(gstruct10_1))
        {
            return true;
        }
        if (gstruct10_0.int_1 < gstruct10_1.int_1)
        {
            return true;
        }
        if (gstruct10_0.int_1 > gstruct10_1.int_1)
        {
            return false;
        }
        if (gstruct10_0.int_0 < gstruct10_1.int_0)
        {
            return true;
        }
        return false;
    }

    [SpecialName]
    public static bool smethod_4(GStruct10 gstruct10_0, GStruct10 gstruct10_1)
    {
        if (gstruct10_0.int_1 > gstruct10_1.int_1)
        {
            return true;
        }
        if (gstruct10_0.int_1 < gstruct10_1.int_1)
        {
            return false;
        }
        if (gstruct10_0.int_0 > gstruct10_1.int_0)
        {
            return true;
        }
        return false;
    }

    [SpecialName]
    public static bool smethod_5(GStruct10 gstruct10_0, GStruct10 gstruct10_1)
    {
        if (gstruct10_0.Equals(gstruct10_1))
        {
            return true;
        }
        if (gstruct10_0.int_1 > gstruct10_1.int_1)
        {
            return true;
        }
        if (gstruct10_0.int_1 < gstruct10_1.int_1)
        {
            return false;
        }
        if (gstruct10_0.int_0 > gstruct10_1.int_0)
        {
            return true;
        }
        return false;
    }

    [SpecialName]
    public static GStruct10 smethod_6(GStruct10 gstruct10_0, GStruct10 gstruct10_1)
    {
        return new GStruct10(gstruct10_0.int_0 + gstruct10_1.int_0, gstruct10_0.int_1 + gstruct10_1.int_1);
    }

    public override readonly string ToString()
    {
        return "(" + int_0 + "," + int_1 + ")";
    }
}
