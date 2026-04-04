using System;
using System.IO;

namespace VaultEditor;

public abstract class GClass500(GEnum23 genum23_1) : GInterface7
{
    protected readonly GEnum23 genum23_0 = genum23_1;

    private int int_0;

    public int int_1 = 16;

    public void imethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0)
    {
        long position = binaryReader_0.BaseStream.Position;
        if (binaryReader_0.ReadInt32() != (int)genum23_0)
        {
            throw new Exception();
        }
        int_0 = binaryReader_0.ReadInt32();
        vmethod_0(genum1_0, binaryReader_0, int_0 - 8);
        binaryReader_0.BaseStream.Seek(position + int_0, SeekOrigin.Begin);
    }

    public void imethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        uint num = (uint)binaryWriter_0.BaseStream.Position;
        binaryWriter_0.Write((int)genum23_0);
        binaryWriter_0.Write(0u);
        vmethod_1(genum1_0, binaryWriter_0);
        binaryWriter_0.smethod_14(int_1, 0);
        long position = binaryWriter_0.BaseStream.Position;
        binaryWriter_0.BaseStream.Position = num + 4;
        uint value = (uint)(int)position - num;
        binaryWriter_0.Write(value);
        binaryWriter_0.BaseStream.Position = position;
    }

    public abstract void vmethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0, int int_2);

    public abstract void vmethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0);
}
