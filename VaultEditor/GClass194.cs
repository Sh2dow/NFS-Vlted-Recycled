using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass194 : GClass154
{
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

    [GAttribute1("IDLE_RPM")]
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

    [GAttribute1("CRZ_LO_RPM")]
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

    [GAttribute1("CRZ_MED_RPM")]
    public int Value3
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

    [GAttribute1("CRZ_HI_RPM")]
    public int Value4
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

    [GAttribute1("LD_LOW_RPM")]
    public int Value5
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

    [GAttribute1("LD_MED_RPM")]
    public int Value6
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

    [GAttribute1("LD_HI_RPM")]
    public int Value7
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

    [GAttribute1("REVLMT_RPM")]
    public int Value8
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadInt32();
        Value2 = binaryReader_0.ReadInt32();
        Value3 = binaryReader_0.ReadInt32();
        Value4 = binaryReader_0.ReadInt32();
        Value5 = binaryReader_0.ReadInt32();
        Value6 = binaryReader_0.ReadInt32();
        Value7 = binaryReader_0.ReadInt32();
        Value8 = binaryReader_0.ReadInt32();
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
        binaryWriter_0.Write(Value8);
    }
}
