using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass225 : GClass154
{
    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private float float_0;

    [CompilerGenerated]
    private int int_5;

    [CompilerGenerated]
    private float float_1;

    [CompilerGenerated]
    private int int_6;

    [CompilerGenerated]
    private GInterface5 ginterface5_0;

    [CompilerGenerated]
    private GInterface5 ginterface5_1;

    [CompilerGenerated]
    private GInterface5 ginterface5_2;

    [CompilerGenerated]
    private int int_7;

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

    [GAttribute1("2")]
    public int Value2
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

    [GAttribute1("3")]
    public float Value3
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
    public float Value5
    {
        [CompilerGenerated]
        get
        {
            return float_1;
        }
        [CompilerGenerated]
        set
        {
            float_1 = value;
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
    public GInterface5 Value7
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_0;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_0 = value;
        }
    }

    [GAttribute1("9")]
    public GInterface5 Value9
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_1;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_1 = value;
        }
    }

    [GAttribute1("11")]
    public GInterface5 Value11
    {
        [CompilerGenerated]
        get
        {
            return ginterface5_2;
        }
        [CompilerGenerated]
        set
        {
            ginterface5_2 = value;
        }
    }

    [GAttribute1("13")]
    public int Value13
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

    public GClass225()
    {
        Value7 = new GClass517();
        Value9 = new GClass517();
        Value11 = new GClass517();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadInt32();
        Value2 = binaryReader_0.ReadInt32();
        Value3 = binaryReader_0.ReadSingle();
        Value4 = binaryReader_0.ReadInt32();
        Value5 = binaryReader_0.ReadSingle();
        Value6 = binaryReader_0.ReadInt32();
        Value7.imethod_0(binaryReader_0);
        Value9.imethod_0(binaryReader_0);
        Value11.imethod_0(binaryReader_0);
        Value13 = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
        binaryWriter_0.Write(Value3);
        binaryWriter_0.Write(Value4);
        binaryWriter_0.Write(Value5);
        binaryWriter_0.Write(Value6);
        Value7.imethod_1(binaryWriter_0);
        Value9.imethod_1(binaryWriter_0);
        Value11.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(Value13);
    }
}
