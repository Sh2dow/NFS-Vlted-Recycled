using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

internal sealed class Class114
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

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

    public uint Offset
    {
        [CompilerGenerated]
        get
        {
            return uint_1;
        }
        [CompilerGenerated]
        set
        {
            uint_1 = value;
        }
    }

    public void method_0(BinaryReader binaryReader_0)
    {
        Hash = binaryReader_0.ReadUInt32();
        Offset = binaryReader_0.ReadUInt32();
    }
}
