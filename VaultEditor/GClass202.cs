using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass202 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private int int_5;

    [GAttribute1("1")]
    public int Value1
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

    [GAttribute1("2", DataType = GEnum20.const_1)]
    public uint Value2
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

    [GAttribute1("3")]
    public int Value3
    {
        [CompilerGenerated]
        get
        {
            return int_4;
        }
        [CompilerGenerated]
        set
        {
            int_4 = value;
        }
    }

    [GAttribute1("4")]
    public int Value4
    {
        [CompilerGenerated]
        get
        {
            return int_5;
        }
        [CompilerGenerated]
        set
        {
            int_5 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadInt32();
        Value2 = binaryReader_0.ReadUInt32();
        Value3 = binaryReader_0.ReadInt32();
        Value4 = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
        binaryWriter_0.Write(Value3);
        binaryWriter_0.Write(Value4);
    }
}
