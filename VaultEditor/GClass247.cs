using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass247 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private int int_5;

    [CompilerGenerated]
    private int int_6;

    [CompilerGenerated]
    private uint uint_2;

    [CompilerGenerated]
    private GClass519 gclass519_0;

    [CompilerGenerated]
    private GClass519 gclass519_1;

    [CompilerGenerated]
    private GClass519 gclass519_2;

    [CompilerGenerated]
    private int int_7;

    [CompilerGenerated]
    private GInterface5 ginterface5_0;

    [CompilerGenerated]
    private GClass499 gclass499_0;

    [GAttribute1("HAL_ID", DataType = GEnum20.const_1)]
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

    [GAttribute1("CF_HAL_ID", DataType = GEnum20.const_1)]
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

    [GAttribute1("Price")]
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

    [GAttribute1("4")]
    public int Value4
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

    [GAttribute1("7", DataType = GEnum20.const_1)]
    public uint Value7
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

    [GAttribute1("9")]
    public GClass519 CustomValues1
    {
        [CompilerGenerated]
        get
        {
            return gclass519_0;
        }
        [CompilerGenerated]
        set
        {
            gclass519_0 = value;
        }
    }

    [GAttribute1("10")]
    public GClass519 CustomValues2
    {
        [CompilerGenerated]
        get
        {
            return gclass519_1;
        }
        [CompilerGenerated]
        set
        {
            gclass519_1 = value;
        }
    }

    [GAttribute1("11")]
    public GClass519 CustomValues3
    {
        [CompilerGenerated]
        get
        {
            return gclass519_2;
        }
        [CompilerGenerated]
        set
        {
            gclass519_2 = value;
        }
    }

    [GAttribute1("12")]
    public int Value12
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

    [GAttribute1("13")]
    public GInterface5 Value13
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

    public GClass499 Value14
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

    public GClass247()
    {
        CustomValues1 = new GClass519();
        CustomValues2 = new GClass519();
        CustomValues3 = new GClass519();
        Value13 = new GClass511();
        Value14 = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadUInt32();
        Value2 = binaryReader_0.ReadUInt32();
        Value3 = binaryReader_0.ReadInt32();
        Value4 = binaryReader_0.ReadInt32();
        Value5 = binaryReader_0.ReadInt32();
        Value6 = binaryReader_0.ReadInt32();
        Value7 = binaryReader_0.ReadUInt32();
        CustomValues1.Byte_0 = binaryReader_0.ReadByte();
        CustomValues2.Byte_0 = binaryReader_0.ReadByte();
        CustomValues3.Byte_0 = binaryReader_0.ReadByte();
        binaryReader_0.ReadByte();
        CustomValues1.imethod_0(binaryReader_0);
        CustomValues2.imethod_0(binaryReader_0);
        CustomValues3.imethod_0(binaryReader_0);
        Value12 = binaryReader_0.ReadInt32();
        Value13.imethod_0(binaryReader_0);
        Value14.imethod_0(binaryReader_0);
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
        binaryWriter_0.Write(CustomValues1.Byte_0);
        binaryWriter_0.Write(CustomValues2.Byte_0);
        binaryWriter_0.Write(CustomValues3.Byte_0);
        binaryWriter_0.Write((byte)0);
        CustomValues1.imethod_1(binaryWriter_0);
        CustomValues2.imethod_1(binaryWriter_0);
        CustomValues3.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(Value12);
        Value13.imethod_1(binaryWriter_0);
        Value14.imethod_1(binaryWriter_0);
    }
}
