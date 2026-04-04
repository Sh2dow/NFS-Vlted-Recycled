using System;
using System.Diagnostics;

namespace VaultEditor;

internal static class Class20
{
    public static void smethod_0(Struct0<byte> struct0_0, Struct0<byte> struct0_1, long long_0)
    {
        smethod_1(struct0_0, struct0_1, checked((int)long_0));
    }

    public static void smethod_1(Struct0<byte> struct0_0, Struct0<byte> struct0_1, int int_0)
    {
        if (struct0_0.gparam_0 == struct0_1.gparam_0 && struct0_1.int_0 < struct0_0.int_0 + int_0 && struct0_0.int_0 < struct0_1.int_0 + int_0)
        {
            Debugger.Break();
            throw new InvalidOperationException("memcpy cannot handle overlapping regions correctly");
        }
        Buffer.BlockCopy(struct0_1.gparam_0, struct0_1.int_0, struct0_0.gparam_0, struct0_0.int_0, int_0);
    }

    public static void smethod_2(Struct0<byte> struct0_0, Struct0<byte> struct0_1, uint uint_0)
    {
        Buffer.BlockCopy(struct0_1.gparam_0, struct0_1.int_0, struct0_0.gparam_0, struct0_0.int_0, checked((int)uint_0));
    }

    public static T[] smethod_3<T>(int int_0, Func<T> func_0)
    {
        T[] array = new T[int_0];
        for (int i = 0; i < int_0; i++)
        {
            array[i] = func_0();
        }
        return array;
    }

    public static T[][] smethod_4<T>(int int_0, int int_1)
    {
        T[][] array = new T[int_0][];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new T[int_1];
        }
        return array;
    }

    [DebuggerHidden]
    public static void smethod_5(bool bool_0)
    {
        if (!bool_0)
        {
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
            throw new InvalidOperationException("Assertion failed.");
        }
    }
}
