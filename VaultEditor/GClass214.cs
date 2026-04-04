using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass214 : GClass154
{
    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private ushort ushort_1;

    [GAttribute1("PointCount")]
    public ushort PointCount
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

    [GAttribute1("PointStart")]
    public ushort PointStart
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        PointCount = binaryReader_0.ReadUInt16();
        PointStart = binaryReader_0.ReadUInt16();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(PointCount);
        binaryWriter_0.Write(PointStart);
    }
}
