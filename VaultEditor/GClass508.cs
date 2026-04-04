using System;
using System.IO;
using System.Linq;

namespace VaultEditor;

public sealed class GClass508 : GClass500
{
    public GClass508()
        : base(GEnum23.const_2)
    {
    }

    public override void vmethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0, int int_2)
    {
        if (int_2 != 8)
        {
            throw new Exception();
        }
        if (binaryReader_0.ReadBytes(int_2).Any(byte_0 => byte_0 != 0))
        {
            throw new Exception();
        }
    }

    public override void vmethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        for (int i = 0; i < 8; i++)
        {
            binaryWriter_0.Write((byte)0);
        }
    }
}
