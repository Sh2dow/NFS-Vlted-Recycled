using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass468 : GClass154
{
    [CompilerGenerated]
    private long long_0;

    [GAttribute1]
    public long Value
    {
        [CompilerGenerated]
        get
        {
            return long_0;
        }
        [CompilerGenerated]
        set
        {
            long_0 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadInt64();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }
}
