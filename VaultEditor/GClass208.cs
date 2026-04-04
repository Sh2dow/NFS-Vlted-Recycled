using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass208 : GClass154
{
    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private ushort ushort_1;

    [CompilerGenerated]
    private ushort ushort_2;

    [CompilerGenerated]
    private ushort ushort_3;

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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value1 = binaryReader_0.ReadUInt16();
        Value2 = binaryReader_0.ReadUInt16();
        Value3 = binaryReader_0.ReadUInt16();
        Value4 = binaryReader_0.ReadUInt16();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value1);
        binaryWriter_0.Write(Value2);
        binaryWriter_0.Write(Value3);
        binaryWriter_0.Write(Value4);
    }
}
