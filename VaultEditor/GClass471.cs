using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass471 : GClass154
{
    [CompilerGenerated]
    private ushort ushort_0;

    [GAttribute1]
    public ushort Value
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadUInt16();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }
}
