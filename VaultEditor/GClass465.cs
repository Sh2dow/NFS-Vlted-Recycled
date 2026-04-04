using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass465 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [GAttribute1(DataType = GEnum20.const_3)]
    public uint Hash
    {
        [CompilerGenerated]
        get
        {
            return uint_0;
        }
        [CompilerGenerated]
        set
        {
            uint_0 = value;
        }
    }

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        Hash = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(Hash);
    }
}
