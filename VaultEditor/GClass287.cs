using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass287 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private int int_5;

    [CompilerGenerated]
    private int int_6;

    [CompilerGenerated]
    private float float_0;

    [GAttribute1("1", DataType = GEnum20.const_3)]
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

    [GAttribute1("2")]
    public int Value2
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
    public GClass499 Value4
    {
        [CompilerGenerated]
        get
        {
            return gclass499_0;
        }
        [CompilerGenerated]
        set
        {
            gclass499_0 = value;
        }
    }

    [GAttribute1("5")]
    public int Value5
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

    [GAttribute1("6")]
    public int Value6
    {
        [CompilerGenerated]
        get
        {
            return int_6;
        }
        [CompilerGenerated]
        set
        {
            int_6 = value;
        }
    }

    [GAttribute1("7")]
    public float Value7
    {
        [CompilerGenerated]
        get
        {
            return float_0;
        }
        [CompilerGenerated]
        set
        {
            float_0 = value;
        }
    }

    public GClass287()
    {
        Value4 = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadUInt32();
        Value2 = binaryReader_0.ReadInt32();
        Value3 = binaryReader_0.ReadInt32();
        Value4.imethod_0(binaryReader_0);
        Value5 = binaryReader_0.ReadInt32();
        Value6 = binaryReader_0.ReadInt32();
        Value7 = binaryReader_0.ReadSingle();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
        binaryWriter_0.Write(Value3);
        Value4.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(Value5);
        binaryWriter_0.Write(Value6);
        binaryWriter_0.Write(Value7);
    }
}
