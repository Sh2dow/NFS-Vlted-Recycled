using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass283 : GClass154
{
    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private ushort ushort_1;

    [CompilerGenerated]
    private ushort ushort_2;

    [CompilerGenerated]
    private ushort ushort_3;

    [CompilerGenerated]
    private ushort ushort_4;

    [CompilerGenerated]
    private ushort ushort_5;

    [CompilerGenerated]
    private ushort ushort_6;

    [CompilerGenerated]
    private ushort ushort_7;

    [GAttribute1("1")]
    public ushort Value1
    {
        [CompilerGenerated]
        get
        {
            return ushort_0;
        }
        [CompilerGenerated]
        set
        {
            ushort_0 = value;
        }
    }

    [GAttribute1("2")]
    public ushort Value2
    {
        [CompilerGenerated]
        get
        {
            return ushort_1;
        }
        [CompilerGenerated]
        set
        {
            ushort_1 = value;
        }
    }

    [GAttribute1("3")]
    public ushort Value3
    {
        [CompilerGenerated]
        get
        {
            return ushort_2;
        }
        [CompilerGenerated]
        set
        {
            ushort_2 = value;
        }
    }

    [GAttribute1("4")]
    public ushort Value4
    {
        [CompilerGenerated]
        get
        {
            return ushort_3;
        }
        [CompilerGenerated]
        set
        {
            ushort_3 = value;
        }
    }

    [GAttribute1("5")]
    public ushort Value5
    {
        [CompilerGenerated]
        get
        {
            return ushort_4;
        }
        [CompilerGenerated]
        set
        {
            ushort_4 = value;
        }
    }

    [GAttribute1("6")]
    public ushort Value6
    {
        [CompilerGenerated]
        get
        {
            return ushort_5;
        }
        [CompilerGenerated]
        set
        {
            ushort_5 = value;
        }
    }

    [GAttribute1("7")]
    public ushort Value7
    {
        [CompilerGenerated]
        get
        {
            return ushort_6;
        }
        [CompilerGenerated]
        set
        {
            ushort_6 = value;
        }
    }

    [GAttribute1("8")]
    public ushort Value8
    {
        [CompilerGenerated]
        get
        {
            return ushort_7;
        }
        [CompilerGenerated]
        set
        {
            ushort_7 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadUInt16();
        Value2 = binaryReader_0.ReadUInt16();
        Value3 = binaryReader_0.ReadUInt16();
        Value4 = binaryReader_0.ReadUInt16();
        Value5 = binaryReader_0.ReadUInt16();
        Value6 = binaryReader_0.ReadUInt16();
        Value7 = binaryReader_0.ReadUInt16();
        Value8 = binaryReader_0.ReadUInt16();
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
