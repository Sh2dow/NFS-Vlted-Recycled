using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass274 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private int int_5;

    [CompilerGenerated]
    private int int_6;

    [CompilerGenerated]
    private int int_7;

    [CompilerGenerated]
    private int int_8;

    [CompilerGenerated]
    private int int_9;

    [CompilerGenerated]
    private int int_10;

    [CompilerGenerated]
    private int int_11;

    [CompilerGenerated]
    private int int_12;

    [CompilerGenerated]
    private int int_13;

    [CompilerGenerated]
    private int int_14;

    [CompilerGenerated]
    private int int_15;

    [CompilerGenerated]
    private int int_16;

    [CompilerGenerated]
    private int int_17;

    [GAttribute1("1")]
    public GClass499 Value1
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

    [GAttribute1("5")]
    public int Value5
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

    [GAttribute1("6")]
    public int Value6
    {
        [CompilerGenerated]
        get
        {
            return int_7;
        }
        [CompilerGenerated]
        set
        {
            int_7 = value;
        }
    }

    [GAttribute1("7")]
    public int Value7
    {
        [CompilerGenerated]
        get
        {
            return int_8;
        }
        [CompilerGenerated]
        set
        {
            int_8 = value;
        }
    }

    [GAttribute1("8")]
    public int Value8
    {
        [CompilerGenerated]
        get
        {
            return int_9;
        }
        [CompilerGenerated]
        set
        {
            int_9 = value;
        }
    }

    [GAttribute1("9")]
    public int Value9
    {
        [CompilerGenerated]
        get
        {
            return int_10;
        }
        [CompilerGenerated]
        set
        {
            int_10 = value;
        }
    }

    [GAttribute1("10")]
    public int Value10
    {
        [CompilerGenerated]
        get
        {
            return int_11;
        }
        [CompilerGenerated]
        set
        {
            int_11 = value;
        }
    }

    [GAttribute1("11")]
    public int Value11
    {
        [CompilerGenerated]
        get
        {
            return int_12;
        }
        [CompilerGenerated]
        set
        {
            int_12 = value;
        }
    }

    [GAttribute1("12")]
    public int Value12
    {
        [CompilerGenerated]
        get
        {
            return int_13;
        }
        [CompilerGenerated]
        set
        {
            int_13 = value;
        }
    }

    [GAttribute1("13")]
    public int Value13
    {
        [CompilerGenerated]
        get
        {
            return int_14;
        }
        [CompilerGenerated]
        set
        {
            int_14 = value;
        }
    }

    [GAttribute1("14")]
    public int Value14
    {
        [CompilerGenerated]
        get
        {
            return int_15;
        }
        [CompilerGenerated]
        set
        {
            int_15 = value;
        }
    }

    [GAttribute1("15")]
    public int Value15
    {
        [CompilerGenerated]
        get
        {
            return int_16;
        }
        [CompilerGenerated]
        set
        {
            int_16 = value;
        }
    }

    [GAttribute1("16")]
    public int Value16
    {
        [CompilerGenerated]
        get
        {
            return int_17;
        }
        [CompilerGenerated]
        set
        {
            int_17 = value;
        }
    }

    public GClass274()
    {
        Value1 = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1.imethod_0(binaryReader_0);
        Value2 = binaryReader_0.ReadInt32();
        Value3 = binaryReader_0.ReadInt32();
        Value4 = binaryReader_0.ReadInt32();
        Value5 = binaryReader_0.ReadInt32();
        Value6 = binaryReader_0.ReadInt32();
        Value7 = binaryReader_0.ReadInt32();
        Value8 = binaryReader_0.ReadInt32();
        Value9 = binaryReader_0.ReadInt32();
        Value10 = binaryReader_0.ReadInt32();
        Value11 = binaryReader_0.ReadInt32();
        Value12 = binaryReader_0.ReadInt32();
        Value13 = binaryReader_0.ReadInt32();
        Value14 = binaryReader_0.ReadInt32();
        Value15 = binaryReader_0.ReadInt32();
        Value16 = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        Value1.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(Value2);
        binaryWriter_0.Write(Value3);
        binaryWriter_0.Write(Value4);
        binaryWriter_0.Write(Value5);
        binaryWriter_0.Write(Value6);
        binaryWriter_0.Write(Value7);
        binaryWriter_0.Write(Value8);
        binaryWriter_0.Write(Value9);
        binaryWriter_0.Write(Value10);
        binaryWriter_0.Write(Value11);
        binaryWriter_0.Write(Value12);
        binaryWriter_0.Write(Value13);
        binaryWriter_0.Write(Value14);
        binaryWriter_0.Write(Value15);
        binaryWriter_0.Write(Value16);
    }
}
