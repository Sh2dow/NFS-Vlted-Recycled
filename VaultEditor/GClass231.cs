using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass231 : GClass154
{
    [CompilerGenerated]
    private GClass499 gclass499_0;

    [CompilerGenerated]
    private int int_3;

    [CompilerGenerated]
    private int int_4;

    [CompilerGenerated]
    private GClass499 gclass499_1;

    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [CompilerGenerated]
    private int int_5;

    [CompilerGenerated]
    private GClass499 gclass499_2;

    [GAttribute1("Name")]
    public GClass499 Name
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

    [GAttribute1("PartID")]
    public int PartID
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

    [GAttribute1("SlotID")]
    public int SlotID
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
            return gclass499_1;
        }
        [CompilerGenerated]
        set
        {
            gclass499_1 = value;
        }
    }

    [GAttribute1("6", DataType = GEnum20.const_3)]
    public uint Value6
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

    [GAttribute1("7", DataType = GEnum20.const_3)]
    public uint Value7
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

    [GAttribute1("8")]
    public int Value8
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
    public GClass499 Value5
    {
        [CompilerGenerated]
        get
        {
            return gclass499_2;
        }
        [CompilerGenerated]
        set
        {
            gclass499_2 = value;
        }
    }

    public GClass231()
    {
        Name = new GClass499();
        Value4 = new GClass499();
        Value5 = new GClass499();
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Name.imethod_0(binaryReader_0);
        PartID = binaryReader_0.ReadInt32();
        SlotID = binaryReader_0.ReadInt32();
        Value4.imethod_0(binaryReader_0);
        Value5.imethod_0(binaryReader_0);
        Value6 = binaryReader_0.ReadUInt32();
        Value7 = binaryReader_0.ReadUInt32();
        Value8 = binaryReader_0.ReadInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        Name.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(PartID);
        binaryWriter_0.Write(SlotID);
        Value4.imethod_1(binaryWriter_0);
        Value5.imethod_1(binaryWriter_0);
        binaryWriter_0.Write(Value6);
        binaryWriter_0.Write(Value7);
        binaryWriter_0.Write(Value8);
    }
}
