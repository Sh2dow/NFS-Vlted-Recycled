using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass383 : GClass154
{
    [CompilerGenerated]
    private short short_0;

    [GAttribute1]
    public short Value
    {
        [CompilerGenerated]
        get
        {
            return short_0;
        }
        [CompilerGenerated]
        set
        {
            short_0 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadInt16();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }
}
