using System.IO;
using System.Runtime.CompilerServices;

namespace VaultEditor;

public sealed class GClass262 : GClass154
{
    [CompilerGenerated]
    private uint uint_0;

    [CompilerGenerated]
    private uint uint_1;

    [GAttribute1("TextureType", DataType = GEnum20.const_4)]
    public uint TextureType
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

    [GAttribute1("Index")]
    public uint Index
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

    public override void vmethod_0(BinaryReader binaryReader_0)
    {
        TextureType = binaryReader_0.ReadUInt32();
        Index = binaryReader_0.ReadUInt32();
    }

    public override void vmethod_1(BinaryWriter binaryWriter_0)
    {
        binaryWriter_0.Write(TextureType);
        binaryWriter_0.Write(Index);
    }
}
