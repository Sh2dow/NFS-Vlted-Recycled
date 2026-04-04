using System;

namespace VaultEditor;

public sealed class GClass484
{
    public static ulong smethod_0(byte[] byte_0, ulong ulong_0 = 12379813734277854020uL)
    {
        ulong ulong_1 = ulong_0;
        ulong ulong_2 = ulong_0;
        ulong ulong_3 = 11400714819323198483uL;
        int num = byte_0.Length % 24;
        if (byte_0.Length - num > 0)
        {
            smethod_1(ref ulong_1, ref ulong_2, ref ulong_3, byte_0, 0, byte_0.Length - num);
        }
        if (num > 0)
        {
            smethod_2(ref ulong_1, ref ulong_2, ref ulong_3, byte_0, byte_0.Length - num, num);
        }
        ulong_3 += (ulong)byte_0.Length;
        smethod_3(ref ulong_1, ref ulong_2, ref ulong_3);
        return ulong_3;
    }

    private static void smethod_1(ref ulong ulong_0, ref ulong ulong_1, ref ulong ulong_2, byte[] byte_0, int int_0, int int_1)
    {
        for (int i = int_0; i < int_0 + int_1; i += 24)
        {
            ulong_0 += BitConverter.ToUInt64(byte_0, i);
            ulong_1 += BitConverter.ToUInt64(byte_0, i + 8);
            ulong_2 += BitConverter.ToUInt64(byte_0, i + 16);
            smethod_3(ref ulong_0, ref ulong_1, ref ulong_2);
        }
    }

    private static void smethod_2(ref ulong ulong_0, ref ulong ulong_1, ref ulong ulong_2, byte[] byte_0, int int_0, int int_1)
    {
        switch (int_1)
        {
            default:
                return;
            case 23:
                ulong_2 += (ulong)byte_0[int_0 + 22] << 56;
                goto case 22;
            case 22:
                ulong_2 += (ulong)byte_0[int_0 + 21] << 48;
                goto case 21;
            case 21:
                ulong_2 += (ulong)byte_0[int_0 + 20] << 40;
                goto case 20;
            case 20:
                ulong_2 += (ulong)byte_0[int_0 + 19] << 32;
                goto case 19;
            case 19:
                ulong_2 += (ulong)byte_0[int_0 + 18] << 24;
                goto case 18;
            case 18:
                ulong_2 += (ulong)byte_0[int_0 + 17] << 16;
                goto case 17;
            case 17:
                ulong_2 += (ulong)byte_0[int_0 + 16] << 8;
                goto case 16;
            case 16:
                ulong_1 += (ulong)byte_0[int_0 + 15] << 56;
                goto case 15;
            case 15:
                ulong_1 += (ulong)byte_0[int_0 + 14] << 48;
                goto case 14;
            case 14:
                ulong_1 += (ulong)byte_0[int_0 + 13] << 40;
                goto case 13;
            case 13:
                ulong_1 += (ulong)byte_0[int_0 + 12] << 32;
                goto case 12;
            case 12:
                ulong_1 += (ulong)byte_0[int_0 + 11] << 24;
                goto case 11;
            case 11:
                ulong_1 += (ulong)byte_0[int_0 + 10] << 16;
                goto case 10;
            case 10:
                ulong_1 += (ulong)byte_0[int_0 + 9] << 8;
                goto case 9;
            case 9:
                ulong_1 += byte_0[8];
                goto case 8;
            case 8:
                ulong_0 += (ulong)byte_0[int_0 + 7] << 56;
                goto case 7;
            case 7:
                ulong_0 += (ulong)byte_0[int_0 + 6] << 48;
                goto case 6;
            case 6:
                ulong_0 += (ulong)byte_0[int_0 + 5] << 40;
                goto case 5;
            case 5:
                ulong_0 += (ulong)byte_0[int_0 + 4] << 32;
                goto case 4;
            case 4:
                ulong_0 += (ulong)byte_0[int_0 + 3] << 24;
                goto case 3;
            case 3:
                ulong_0 += (ulong)byte_0[int_0 + 2] << 16;
                goto case 2;
            case 2:
                ulong_0 += (ulong)byte_0[int_0 + 1] << 8;
                break;
            case 1:
                break;
        }
        ulong_0 += byte_0[int_0];
    }

    private static void smethod_3(ref ulong ulong_0, ref ulong ulong_1, ref ulong ulong_2)
    {
        ulong_0 = (ulong_2 >> 43) ^ (ulong_0 - ulong_1 - ulong_2);
        ulong_1 = (ulong_0 << 9) ^ (ulong_1 - ulong_2 - ulong_0);
        ulong_2 = (ulong_1 >> 8) ^ (ulong_2 - ulong_0 - ulong_1);
        ulong_0 = (ulong_2 >> 38) ^ (ulong_0 - ulong_1 - ulong_2);
        ulong_1 = (ulong_0 << 23) ^ (ulong_1 - ulong_2 - ulong_0);
        ulong_2 = (ulong_1 >> 5) ^ (ulong_2 - ulong_0 - ulong_1);
        ulong_0 = (ulong_2 >> 35) ^ (ulong_0 - ulong_1 - ulong_2);
        ulong_1 = (ulong_0 << 49) ^ (ulong_1 - ulong_2 - ulong_0);
        ulong_2 = (ulong_1 >> 11) ^ (ulong_2 - ulong_0 - ulong_1);
        ulong_0 = (ulong_2 >> 12) ^ (ulong_0 - ulong_1 - ulong_2);
        ulong_1 = (ulong_0 << 18) ^ (ulong_1 - ulong_2 - ulong_0);
        ulong_2 = (ulong_1 >> 22) ^ (ulong_2 - ulong_0 - ulong_1);
    }
}
