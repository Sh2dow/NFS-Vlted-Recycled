using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass473 : GClass154
{
    [CompilerGenerated]
    private ulong ulong_0;

    [GAttribute1]
    public ulong Value
    {
        [CompilerGenerated]
        get
        {
            return ulong_0;
        }
        [CompilerGenerated]
        set
        {
            ulong_0 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadUInt64();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }
}
