using System;
using System.IO;

namespace VaultEditor;

public sealed class GClass501 : GClass500
{
    public GClass501()
        : base(GEnum23.const_7)
    {
        int_1 = 16;
    }

    public override void vmethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0, int int_2)
    {
        int num = binaryReader_0.smethod_3(int_1) + 8;
        if (num != int_1)
        {
            throw new Exception();
        }
        binaryReader_0.ReadBytes(num);
    }

    public override void vmethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        int num = binaryWriter_0.smethod_14(int_1, 0);
        for (int i = 0; i < num; i++)
        {
        }
    }
}
