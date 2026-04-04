using System;
using System.IO;

namespace VaultEditor;

public sealed class GClass502 : GClass500
{
    private ulong ulong_0;

    public GClass502()
        : base(GEnum23.const_6)
    {
    }

    public override void vmethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0, int int_2)
    {
        if (int_2 != 8)
        {
            throw new Exception();
        }
        ulong num = binaryReader_0.ReadUInt64();
        if (num != ulong_0)
        {
        }
        ulong_0 = num;
    }

    public override void vmethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(ulong_0);
    }
}
