using System;

namespace VaultEditor;

public sealed class GClass485
{
    public static uint smethod_0(byte[] byte_0, uint uint_0 = 2882400000u)
    {
        uint uint_1 = 2654435769u;
        uint uint_2 = 2654435769u;
        uint uint_3 = uint_0;
        int num = byte_0.Length % 12;
        if (byte_0.Length - num > 0)
        {
            smethod_1(ref uint_1, ref uint_2, ref uint_3, byte_0, 0, byte_0.Length - num);
        }
        if (num > 0)
        {
            smethod_2(ref uint_1, ref uint_2, ref uint_3, byte_0, byte_0.Length - num, num);
        }
        uint_3 += (uint)byte_0.Length;
        smethod_3(ref uint_1, ref uint_2, ref uint_3);
        return uint_3;
    }

    private static void smethod_1(ref uint uint_0, ref uint uint_1, ref uint uint_2, byte[] byte_0, int int_0, int int_1)
    {
        for (int i = int_0; i < int_0 + int_1; i += 12)
        {
            uint_0 += BitConverter.ToUInt32(byte_0, i);
            uint_1 += BitConverter.ToUInt32(byte_0, i + 4);
            uint_2 += BitConverter.ToUInt32(byte_0, i + 8);
            smethod_3(ref uint_0, ref uint_1, ref uint_2);
        }
    }

    private static void smethod_2(ref uint uint_0, ref uint uint_1, ref uint uint_2, byte[] byte_0, int int_0, int int_1)
    {
        switch (int_1)
        {
            default:
                return;
            case 3:
                uint_0 += (uint)(byte_0[int_0 + 2] << 16);
                goto case 2;
            case 2:
                uint_0 += (uint)(byte_0[int_0 + 1] << 8);
                goto case 1;
            case 1:
                uint_0 += byte_0[int_0];
                return;
            case 7:
                uint_1 += (uint)(byte_0[int_0 + 6] << 16);
                goto case 6;
            case 6:
                uint_1 += (uint)(byte_0[int_0 + 5] << 8);
                goto case 5;
            case 5:
                uint_1 += byte_0[int_0 + 4];
                break;
            case 11:
                uint_2 += (uint)(byte_0[int_0 + 10] << 24);
                goto case 10;
            case 10:
                uint_2 += (uint)(byte_0[int_0 + 9] << 16);
                goto case 9;
            case 9:
                uint_2 += (uint)(byte_0[int_0 + 8] << 8);
                goto case 8;
            case 8:
                uint_1 += BitConverter.ToUInt32(byte_0, int_0 + 4);
                break;
            case 4:
                break;
        }
        uint_0 += BitConverter.ToUInt32(byte_0, int_0);
    }

    private static void smethod_3(ref uint uint_0, ref uint uint_1, ref uint uint_2)
    {
        uint_0 -= uint_1;
        uint_0 -= uint_2;
        uint_0 ^= uint_2 >> 13;
        uint_1 -= uint_2;
        uint_1 -= uint_0;
        uint_1 ^= uint_0 << 8;
        uint_2 -= uint_0;
        uint_2 -= uint_1;
        uint_2 ^= uint_1 >> 13;
        uint_0 -= uint_1;
        uint_0 -= uint_2;
        uint_0 ^= uint_2 >> 12;
        uint_1 -= uint_2;
        uint_1 -= uint_0;
        uint_1 ^= uint_0 << 16;
        uint_2 -= uint_0;
        uint_2 -= uint_1;
        uint_2 ^= uint_1 >> 5;
        uint_0 -= uint_1;
        uint_0 -= uint_2;
        uint_0 ^= uint_2 >> 3;
        uint_1 -= uint_2;
        uint_1 -= uint_0;
        uint_1 ^= uint_0 << 10;
        uint_2 -= uint_0;
        uint_2 -= uint_1;
        uint_2 ^= uint_1 >> 15;
    }
}
