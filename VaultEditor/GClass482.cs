using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass482
{
    private GEnum19 genum19_0;

    private byte byte_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    public int DataSize
    {
        [CompilerGenerated]
        get
        {
            return int_0;
        }
        [CompilerGenerated]
        set
        {
            int_0 = value;
        }
    }

    public int BlockSize
    {
        [CompilerGenerated]
        get
        {
            return int_1;
        }
        [CompilerGenerated]
        set
        {
            int_1 = value;
        }
    }

    public GEnum19 GEnum19_0
    {
        get
        {
            return genum19_0;
        }
        set
        {
            switch (value)
            {
                case GEnum19.const_1:
                    byte_0 = 2;
                    break;
                case GEnum19.const_3:
                    byte_0 = 1;
                    break;
                case GEnum19.const_2:
                    byte_0 = 1;
                    break;
            }
            genum19_0 = value;
        }
    }

    public int Int32_0 => 16;

    public GClass482()
    {
        GEnum19_0 = GEnum19.const_3;
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        GEnum19_0 = (GEnum19)binaryReader_0.ReadUInt32();
        GEnum19_0.smethod_0();
        byte_0 = binaryReader_0.ReadByte();
        if (binaryReader_0.ReadByte() != Int32_0)
        {
            throw new Exception();
        }
        if (binaryReader_0.ReadUInt16() != 0)
        {
            throw new Exception();
        }
        DataSize = binaryReader_0.ReadInt32();
        BlockSize = binaryReader_0.ReadInt32();
    }

    public void method_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write((uint)GEnum19_0);
        binaryWriter_0.Write(byte_0);
        binaryWriter_0.Write((byte)Int32_0);
        binaryWriter_0.Write((ushort)0);
        binaryWriter_0.Write(DataSize);
        binaryWriter_0.Write(BlockSize);
    }
}
