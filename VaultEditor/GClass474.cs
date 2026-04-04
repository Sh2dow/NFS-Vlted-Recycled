using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass474 : GClass154
{
    [CompilerGenerated]
    private byte byte_0;

    [GAttribute1]
    public byte Value
    {
        [CompilerGenerated]
        get
        {
            return byte_0;
        }
        [CompilerGenerated]
        set
        {
            byte_0 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Value = binaryReader_0.ReadByte();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Value);
    }
}
