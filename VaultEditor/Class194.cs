using System;

namespace VaultEditor;

internal static class Class194
{
    public static int smethod_0(this int int_0, int int_1)
    {
        int num = int_0 % int_1;
        if (num != 0)
        {
            return int_1 - num;
        }
        return 0;
    }

    public static long smethod_1(this long long_0, long long_1)
    {
        long num = long_0 % long_1;
        if (num != 0L)
        {
            return long_1 - num;
        }
        return 0L;
    }

    public static float smethod_2(this float float_0)
    {
        byte[] bytes = BitConverter.GetBytes(float_0);
        Array.Reverse(bytes);
        return BitConverter.ToSingle(bytes, 0);
    }

    public static short smethod_3(this short short_0)
    {
        byte[] bytes = BitConverter.GetBytes(short_0);
        Array.Reverse(bytes);
        return BitConverter.ToInt16(bytes, 0);
    }

    public static ushort smethod_4(this ushort ushort_0)
    {
        byte[] bytes = BitConverter.GetBytes(ushort_0);
        Array.Reverse(bytes);
        return BitConverter.ToUInt16(bytes, 0);
    }

    public static int smethod_5(this int int_0)
    {
        byte[] bytes = BitConverter.GetBytes(int_0);
        Array.Reverse(bytes);
        return BitConverter.ToInt32(bytes, 0);
    }

    public static long smethod_6(this long long_0)
    {
        byte[] bytes = BitConverter.GetBytes(long_0);
        Array.Reverse(bytes);
        return BitConverter.ToInt64(bytes, 0);
    }

    public static uint smethod_7(this uint uint_0)
    {
        byte[] bytes = BitConverter.GetBytes(uint_0);
        Array.Reverse(bytes);
        return BitConverter.ToUInt32(bytes, 0);
    }

    public static bool smethod_8(this string string_0, out uint uint_0)
    {
        uint_0 = 0u;
        if (string_0 == null)
        {
            return false;
        }
        try
        {
            uint_0 = Convert.ToUInt32(string_0, 16);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
