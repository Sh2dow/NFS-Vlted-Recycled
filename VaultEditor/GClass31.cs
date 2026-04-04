using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace VaultEditor;

public sealed class GClass31(GClass1 gclass1_1, GClass28 gclass28_1) : GClass30
{
    private readonly GClass1 gclass1_0 = gclass1_1;

    private readonly GClass28 gclass28_0 = gclass28_1;

    private readonly int int_0 = 19;

    public GClass31(GClass1 gclass1_1)
        : this(gclass1_1, GClass28.smethod_0())
    {
    }

    internal override GStruct6 vmethod_0()
    {
        return GStruct6.GStruct6_7;
    }

    internal override byte[] vmethod_2()
    {
        byte[] byte_ = gclass28_0.byte_0;
        int num = byte_.Length;
        while (num > 0 && byte_[num - 1] == 0)
        {
            num--;
        }
        byte[] byte_2 = gclass28_0.byte_1;
        int num2 = byte_2.Length;
        while (num2 > 0 && byte_2[num2 - 1] == 0)
        {
            num2--;
        }
        if (num == 0 && num2 == 0)
        {
            return [(byte)int_0];
        }
        List<byte> list = [];
        byte b = (byte)int_0;
        if (num > 0)
        {
            b |= 0x80;
        }
        if (num2 > 0)
        {
            b |= 0x40;
        }
        list.Add(b);
        int num3 = ((num != 0) ? (num - 1) : 0);
        int num4 = ((num2 != 0) ? (num2 - 1) : 0);
        list.Add((byte)((num3 << 4) | num4));
        list.AddRange(byte_);
        list.AddRange(byte_2);
        return [.. list];
    }

    internal override Class42 vmethod_1()
    {
        GStruct1 gstruct1_ = default;
        byte[] gparam_ = null;
        byte[] gparam_2 = null;
        try
        {
            gstruct1_ = gclass1_0.method_0();
            gparam_2 = Encoding.Unicode.GetBytes(GStruct1.smethod_2(gstruct1_));
            gparam_ = Class28.smethod_0(int_0, gclass28_0.byte_0, gparam_2);
            using Aes aes = Aes.Create();
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.None;
            return new Class43(aes.CreateEncryptor(gparam_, gclass28_0.byte_2));
        }
        finally
        {
            gstruct1_.Dispose();
            Class19.smethod_2(ref gparam_2);
            Class19.smethod_2(ref gparam_);
        }
    }
}
