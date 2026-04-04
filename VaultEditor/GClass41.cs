using System;

namespace VaultEditor;

public sealed class GClass41
{
    private static readonly uint uint_0;

    private static readonly int int_0;

    internal readonly uint uint_1;

    internal readonly byte byte_0;

    internal readonly byte byte_1;

    internal readonly byte byte_2;

    internal GClass41(uint uint_2, byte byte_3, byte byte_4, byte byte_5)
    {
        if ((uint_1 = uint_2) < 4096)
        {
            uint_1 = 4096u;
        }
        if ((byte_0 = byte_3) > 8)
        {
            throw new ArgumentOutOfRangeException("lc");
        }
        if ((byte_1 = byte_4) > 4)
        {
            throw new ArgumentOutOfRangeException("pb");
        }
        if ((byte_2 = byte_5) > 4)
        {
            throw new ArgumentOutOfRangeException("lp");
        }
    }

    public static GClass41 smethod_0(byte[] byte_3, int int_1)
    {
        byte num = byte_3[int_1];
        byte byte_4 = (byte)(num % 9);
        byte num2 = (byte)(num / 9);
        byte byte_5 = (byte)(num2 / 5);
        byte byte_6 = (byte)(num2 % 5);
        return new GClass41((uint)(byte_3[int_1 + 1] | (byte_3[int_1 + 2] << 8) | (byte_3[int_1 + 3] << 16) | (byte_3[int_1 + 4] << 24)), byte_4, byte_5, byte_6);
    }

    public static GClass41 smethod_1(byte[] byte_3)
    {
        return smethod_0(byte_3, 0);
    }

    public void method_0(byte[] byte_3, int int_1)
    {
        byte_3[int_1] = (byte)((byte_1 * 5 + byte_2) * 9 + byte_0);
        byte_3[int_1 + 1] = (byte)uint_1;
        byte_3[int_1 + 2] = (byte)(uint_1 >> 8);
        byte_3[int_1 + 3] = (byte)(uint_1 >> 16);
        byte_3[int_1 + 4] = (byte)(uint_1 >> 24);
    }

    public byte[] method_1()
    {
        byte[] array = new byte[5];
        method_0(array, 0);
        return array;
    }
}
