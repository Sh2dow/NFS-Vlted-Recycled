using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass375 : GClass154
{
    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private ushort ushort_1;

    [CompilerGenerated]
    private ushort ushort_2;

    [GAttribute1("Point0")]
    public ushort Point0
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

    [GAttribute1("Point1")]
    public ushort Point1
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

    [GAttribute1("Point2")]
    public ushort Point2
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Point0 = binaryReader_0.ReadUInt16();
        Point1 = binaryReader_0.ReadUInt16();
        Point2 = binaryReader_0.ReadUInt16();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Point0);
        binaryWriter_0.Write(Point1);
        binaryWriter_0.Write(Point2);
    }
}
