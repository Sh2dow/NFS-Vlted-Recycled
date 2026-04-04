using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass215 : GClass154
{
    [CompilerGenerated]
    private ushort ushort_0;

    [CompilerGenerated]
    private ushort ushort_1;

    [GAttribute1("CurveIndex")]
    public ushort CurveIndex
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

    [GAttribute1("Flags")]
    public ushort Flags
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
        CurveIndex = binaryReader_0.ReadUInt16();
        Flags = binaryReader_0.ReadUInt16();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(CurveIndex);
        binaryWriter_0.Write(Flags);
    }
}
