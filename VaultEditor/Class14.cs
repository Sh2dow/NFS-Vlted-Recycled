using System;
using System.IO;

namespace VaultEditor;

internal static class Class14
{
    public static uint uint_0;

    private static readonly uint[] uint_1;

    static Class14()
    {
        uint_1 = new uint[1024];
        for (uint num = 0u; num < 256; num++)
        {
            uint num2 = num;
            for (int i = 0; i < 8; i++)
            {
                num2 = (num2 >> 1) ^ (0xEDB88320u & ~((num2 & 1) - 1));
            }
            uint_1[num] = num2;
        }
        for (uint num3 = 256u; num3 < uint_1.Length; num3++)
        {
            uint num4 = uint_1[num3 - 256];
            uint_1[num3] = uint_1[num4 & 0xFF] ^ (num4 >> 8);
        }
    }

    public static uint smethod_0(Stream stream_0, long long_0)
    {
        uint uint_ = uint.MaxValue;
        byte[] array = new byte[Math.Min(long_0, 4096L)];
        while (long_0 > 0L)
        {
            int num = stream_0.Read(array, 0, (int)Math.Min(long_0, array.Length));
            if (num != 0)
            {
                uint_ = smethod_7(uint_, array, 0, num);
                long_0 -= num;
                continue;
            }
            throw new EndOfStreamException();
        }
        return smethod_1(uint_);
    }

    public static uint smethod_1(uint uint_2)
    {
        return ~uint_2;
    }

    public static uint smethod_2(uint uint_2, byte byte_0)
    {
        return uint_1[(uint_2 & 0xFF) ^ byte_0] ^ (uint_2 >> 8);
    }

    public static uint smethod_3(uint uint_2, uint uint_3)
    {
        uint_2 ^= uint_3;
        return uint_1[768 + (uint_2 & 0xFF)] ^ uint_1[512 + ((uint_2 >> 8) & 0xFF)] ^ uint_1[256 + ((uint_2 >> 16) & 0xFF)] ^ uint_1[uint_2 >> 24];
    }

    public static uint smethod_4(uint uint_2, int int_0)
    {
        return smethod_3(uint_2, (uint)int_0);
    }

    public static uint smethod_5(uint uint_2, ulong ulong_0)
    {
        return smethod_3(smethod_3(uint_2, (uint)ulong_0), (uint)(ulong_0 >> 32));
    }

    public static uint smethod_6(uint uint_2, long long_0)
    {
        return smethod_5(uint_2, (ulong)long_0);
    }

    public static uint smethod_7(uint uint_2, byte[] byte_0, int int_0, int int_1)
    {
        for (int i = 0; i < int_1; i++)
        {
            uint_2 = smethod_2(uint_2, byte_0[int_0 + i]);
        }
        return uint_2;
    }
}
