using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass180 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [GAttribute1("CollectionKey", DataType = GEnum20.const_3)]
    public uint CollectionKey
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
        CollectionKey = binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(CollectionKey);
        binaryWriter_0.Write(0u);
    }
}
