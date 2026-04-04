using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass149 : GInterface7
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private GEnum22 genum22_0;

    [CompilerGenerated]
    private int int_0;

    [CompilerGenerated]
    private int int_1;

    [CompilerGenerated]
    private int int_2;

    public uint Id
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
        [CompilerGenerated]
        set
        {
            uint_0 = value;
        }
    }

    public GEnum22 ExpressionType
    {
        [CompilerGenerated]
        get
        {
            return genum22_0;
        }
        [CompilerGenerated]
        set
        {
            genum22_0 = value;
        }
    }

    public int Length
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

    public int Offset
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

    public int Size
    {
        [CompilerGenerated]
        get
        {
            return int_2;
        }
        [CompilerGenerated]
        set
        {
            int_2 = value;
        }
    }

    public void imethod_0(GEnum1 genum1_0, BinaryReader binaryReader_0)
    {
        Id = binaryReader_0.ReadUInt32();
        ExpressionType = (GEnum22)binaryReader_0.ReadUInt32();
        ExpressionType.smethod_0();
        Length = binaryReader_0.ReadInt32();
        if (genum1_0 == GEnum1.const_3)
        {
            Size = binaryReader_0.ReadInt32();
        }
        Offset = binaryReader_0.ReadInt32();
    }

    public void imethod_1(GEnum1 genum1_0, BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Id);
        binaryWriter_0.Write((uint)ExpressionType);
        binaryWriter_0.Write(Length);
        if (genum1_0 == GEnum1.const_3)
        {
            binaryWriter_0.Write(Size);
        }
        binaryWriter_0.Write(Offset);
    }
}
