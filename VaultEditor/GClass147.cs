using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass147
{
    [CompilerGenerated]
    private GEnum16 genum16_0;

    [CompilerGenerated]
    private uint uint_0;

    public GEnum16 Magic
    {
        [CompilerGenerated]
        get
        {
            return genum16_0;
        }
        [CompilerGenerated]
        set
        {
            genum16_0 = value;
        }
    }

    public uint EntriesCount
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

    public void method_0(BinaryReader binaryReader_0)
    {
        binaryReader_0.ReadUInt32();
        binaryReader_0.ReadUInt32();
        Magic = (GEnum16)binaryReader_0.ReadUInt32();
        EntriesCount = binaryReader_0.ReadUInt32();
    }
}
