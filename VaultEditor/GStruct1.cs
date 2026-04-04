using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VaultEditor;

[DebuggerDisplay("\\{Password {new System.String(mPassword)}\\}")]
public struct GStruct1(char[] char_1) : IDisposable, IEquatable<GStruct1>
{
    private char[] char_0 = char_1;

    public readonly char[] Char_0 => char_0;

    public readonly int Int32_0
    {
        get
        {
            if (char_0 == null)
            {
                return 0;
            }
            return char_0.Length;
        }
    }

    public char this[int int_0]
    {
        get
        {
            if (int_0 < 0 || int_0 >= Int32_0)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            return char_0[int_0];
        }
    }

    public void Dispose()
    {
        Class19.smethod_2(ref char_0);
    }

    public override readonly string ToString()
    {
        return "{Password}";
    }

    public override readonly int GetHashCode()
    {
        int num = -2128831035;
        for (int i = 0; i < char_0.Length; i++)
        {
            num = (num ^ char_0[i]) * 16777619;
        }
        return num;
    }

    public override bool Equals(object obj)
    {
        if (obj is GStruct1)
        {
            return Equals((GStruct1)obj);
        }
        return false;
    }

    public readonly bool Equals(GStruct1 other)
    {
        char[] array = char_0;
        char[] array2 = other.char_0;
        if (array == array2)
        {
            return true;
        }
        if (array != null && array2 != null)
        {
            if (array.Length != array2.Length)
            {
                return false;
            }
            int num = 0;
            while (true)
            {
                if (num < array.Length)
                {
                    if (array[num] != array2[num])
                    {
                        break;
                    }
                    num++;
                    continue;
                }
                return true;
            }
            return false;
        }
        return false;
    }

    [SpecialName]
    public static bool smethod_0(GStruct1 gstruct1_0, GStruct1 gstruct1_1)
    {
        return gstruct1_0.Equals(gstruct1_1);
    }

    [SpecialName]
    public static bool smethod_1(GStruct1 gstruct1_0, GStruct1 gstruct1_1)
    {
        return !gstruct1_0.Equals(gstruct1_1);
    }

    [SpecialName]
    public static char[] smethod_2(GStruct1 gstruct1_0)
    {
        return gstruct1_0.char_0;
    }
}
