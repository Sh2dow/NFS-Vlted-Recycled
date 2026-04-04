using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass249 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private uint uint_3;

    [CompilerGenerated]
    private uint uint_4;

    [CompilerGenerated]
    private uint uint_5;

    [GAttribute1("Group", DataType = GEnum20.const_3)]
    public uint Value1
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

    [GAttribute1("Name", DataType = GEnum20.const_3)]
    public uint Value2
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
        [CompilerGenerated]
        set
        {
            uint_1 = value;
        }
    }

    [GAttribute1("3")]
    public int Value3
    {
        [CompilerGenerated]
        get
        {
            return int_3;
        }
        [CompilerGenerated]
        set
        {
            int_3 = value;
        }
    }

    [GAttribute1("4", DataType = GEnum20.const_3)]
    public uint Value4
    {
        [CompilerGenerated]
        get
        {
            return uint_2;
        }
        [CompilerGenerated]
        set
        {
            uint_2 = value;
        }
    }

    [GAttribute1("5", DataType = GEnum20.const_3)]
    public uint Value5
    {
        [CompilerGenerated]
        get
        {
            return uint_3;
        }
        [CompilerGenerated]
        set
        {
            uint_3 = value;
        }
    }

    [GAttribute1("6", DataType = GEnum20.const_3)]
    public uint Value6
    {
        [CompilerGenerated]
        get
        {
            return uint_4;
        }
        [CompilerGenerated]
        set
        {
            uint_4 = value;
        }
    }

    [GAttribute1("7", DataType = GEnum20.const_3)]
    public uint Value7
    {
        [CompilerGenerated]
        get
        {
            return uint_5;
        }
        [CompilerGenerated]
        set
        {
            uint_5 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadUInt32();
        Value2 = binaryReader_0.ReadUInt32();
        Value3 = binaryReader_0.ReadInt32();
        Value4 = binaryReader_0.ReadUInt32();
        Value5 = binaryReader_0.ReadUInt32();
        Value6 = binaryReader_0.ReadUInt32();
        Value7 = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
        binaryWriter_0.Write(Value3);
        binaryWriter_0.Write(Value4);
        binaryWriter_0.Write(Value5);
        binaryWriter_0.Write(Value6);
        binaryWriter_0.Write(Value7);
    }
}
